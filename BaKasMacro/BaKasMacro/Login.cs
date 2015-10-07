/*
 * SharpDevelop으로 작성되었습니다.
 * 사용자: IJMAIL
 * 날짜: 2015-10-07
 * 시간: 오후 1:09
 * 
 * 이 템플리트를 변경하려면 [도구->옵션->코드 작성->표준 헤더 편집]을 이용하십시오.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaKasMacro
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			OpenMysql();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private Boolean _idCheckd = false;
		private Boolean _pwCheckd = false;
		private Boolean _pwLenCheckd = false;
		MySqlConnection _MConn;
		public string _strSql = "Data Source=197.200.32.79;Database=bakas;User Id=root;Password=1234;Charset=utf8"; 

		void OpenMysql()
		{
			_MConn = new MySqlConnection(_strSql);
			_MConn.Open();
		}
		
		void CloseMysql() {
			_MConn.Close();
		}
		
		
		
		void LoginLoad(object sender, EventArgs e)
		{
			if(!checkBox1.Checked) {
				ClientSize = new System.Drawing.Size(287, 128);
				label3.Text = "회원 접속을 시도합니다.";
			}
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if(!checkBox1.Checked) {
				ClientSize = new System.Drawing.Size(287, 128);
				textBox1.Enabled = true;		// 아이디 입력창
				textBox2.Enabled = true;		// 비번 입력창
				button1.Enabled = true;			// 로그인 버튼
				button2.Enabled = true;			// 취소 버튼
				JoinTextClear();
				label3.Text = "회원 접속을 시도합니다.";
				
			} else {
				ClientSize = new System.Drawing.Size(287, 270);
				txtId.Focus();
				textBox1.Enabled = false;
				textBox2.Enabled = false;
				button1.Enabled = false;
				button2.Enabled = false;
				label3.Text = "회원 가입을 진행합니다.";
			}
	
		}

		void JoinTextClear()
		{
			txtId.Clear();
			txtPw1.Clear();
			txtPw2.Clear();
			label4.Text="";
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text != "" && textBox2.Text != "") {
				OpenMysql();
				string _sql = "select id, pw from member where id = '" + textBox1.Text + "'";
				var _comm = new MySqlCommand(_sql, _MConn);
				var _myRead = _comm.ExecuteReader();
				
				if(_myRead.HasRows) {
					if(_myRead.Read()) {
						if(_myRead["pw"].ToString() == textBox2.Text) {
							CloseMysql();
							MessageBox.Show("로그인 되었습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
							MainForm _mainForm = new MainForm();
							_mainForm.Show();
							this.Hide();
						} else {
							label3.Text = "암호가 일치하지 않습니다";
						}
							
					} else {
						label3.Text = "일치하는 계정이 없습니다";
					}
				}
				_myRead.Close();
				CloseMysql();
			} else {
				label3.Text = "아이디와 암호를 입력하세요";
			}
	
		}
		
		// DB 연결 Test
		void Button3Click(object sender, EventArgs e)
		{
			OpenMysql();
			if(_MConn.Ping() == true)
			{
				MessageBox.Show("Connected to DB ok...");
			} else {
				MessageBox.Show("Connected to DB failed...");
			}
			
			CloseMysql();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Dispose();
			Application.ExitThread();
		}
		
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			if(textBox2.Text !="" && e.KeyChar == (Char)13) {
				OpenMysql();
				e.Handled = true;
				if(textBox1.Text != "" && textBox2.Text != "") {
					string _sql = "select id, pw from member where id = '" + textBox1.Text + "'";
					var _comm = new MySqlCommand(_sql, _MConn);
					var _myRead = _comm.ExecuteReader();
					if(_myRead.HasRows) {
						if(_myRead.Read()) {
						if(_myRead["pw"].ToString() == textBox2.Text) {
							CloseMysql();
							MessageBox.Show("로그인 되었습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
							MainForm _mainForm = new MainForm();
							_mainForm.Show();
							this.Hide();
						} else {
							label3.Text = "암호가 일치하지 않습니다";
						}
							
					} else {
						label3.Text = "일치하는 계정이 없습니다";
					}
				}
					_myRead.Close();
					CloseMysql();
				} else {
					label3.Text = "아이디와 암호를 입력하세요";
				}
			}
		}		// TextBox2KeyPress End
		
		
		void IdCheckClick(object sender, EventArgs e)
		{
			if(txtId.Text != "" || txtId.Text.Length < 4) {
				OpenMysql();
				string _sql = "select id, pw from member where id = '" + txtId.Text + "'";
				var _comm = new MySqlCommand(_sql, _MConn);
				var _myRead = _comm.ExecuteReader();
				if (_myRead.HasRows) {
				
					CloseMysql();
					_idCheckd = false;
					label4.ForeColor = Color.Red;
					label4.Text = "아이디 중복";
				} else {
					CloseMysql();
					_idCheckd = true;
					label4.ForeColor = Color.Blue;
					label4.Text = "Ok 확인";
				}
			} else {
				MessageBox.Show("아이디를 4자리 이상 입력하세요", "아이디 입력", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtId.Focus();
			}
		}	// IdCheckClick End
		
		
		void BtnJoinClick(object sender, EventArgs e)
		{
			if(_idCheckd) {		// 중복체크
				pwCheckd();
				pwLenCheck();
				
				if(_pwCheckd) {
					if(_pwLenCheckd) {
						OpenMysql();
						string _sql = "insert into member(id, pw) value('" +txtId.Text + "', '" + txtPw1.Text +"')";
						var _comm = new MySqlCommand(_sql, _MConn);
						int i = _comm.ExecuteNonQuery();
						//_comm.ExecuteNonQuery();
						
						if(i == 1) {
							CloseMysql();
							checkBox1.Checked = false;
							textBox1.Focus();
							MessageBox.Show("가입이 완료되었습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
							JoinTextClear();
						}
					} else {
						MessageBox.Show("암호를 4자리 이상으로 설정하세요", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtPw1.Clear();
						txtPw2.Clear();
						txtPw1.Focus();
					}
				
				} else {
					MessageBox.Show("패스워드가 일치하지 않습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtPw1.Focus();
				}
			
			} else {
				MessageBox.Show("ID 중복체크를 해주시기 바랍니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtId.Focus();
			}
		}
		// BtnJoinClick End
		
		
		
		void pwCheckd()
		{
			if(txtPw1.Text == txtPw2.Text) {
				_pwCheckd = true;
			} else {
				_pwCheckd = false;	
			}
		}

		void pwLenCheck()
		{
			if(txtPw1.Text.Length > 3) {
				_pwLenCheckd = true;
			} else {
				_pwLenCheckd = false;
			}
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			checkBox1.Checked = false;
			JoinTextClear();
			textBox1.Focus();
		}
	}	// class End
}
