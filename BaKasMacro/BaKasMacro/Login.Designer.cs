﻿/*
 * SharpDevelop으로 작성되었습니다.
 * 사용자: IJMAIL
 * 날짜: 2015-10-07
 * 시간: 오후 1:09
 * 
 * 이 템플리트를 변경하려면 [도구->옵션->코드 작성->표준 헤더 편집]을 이용하십시오.
 */
namespace BaKasMacro
{
	partial class Login
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnJoin;
		private System.Windows.Forms.Button idCheck;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPw2;
		private System.Windows.Forms.TextBox txtPw1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnJoin = new System.Windows.Forms.Button();
			this.idCheck = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPw2 = new System.Windows.Forms.TextBox();
			this.txtPw1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "아이디";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(25, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "비밀번호";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(88, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 21);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(88, 55);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(100, 21);
			this.textBox2.TabIndex = 3;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2KeyPress);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(211, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(58, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "로그인";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(211, 55);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(58, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "취  소";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 12);
			this.label3.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(193, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 12);
			this.label4.TabIndex = 7;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(224, 82);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(38, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "취소";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// btnJoin
			// 
			this.btnJoin.Location = new System.Drawing.Point(186, 82);
			this.btnJoin.Name = "btnJoin";
			this.btnJoin.Size = new System.Drawing.Size(38, 23);
			this.btnJoin.TabIndex = 9;
			this.btnJoin.Text = "가입";
			this.btnJoin.UseVisualStyleBackColor = true;
			this.btnJoin.Click += new System.EventHandler(this.BtnJoinClick);
			// 
			// idCheck
			// 
			this.idCheck.Location = new System.Drawing.Point(203, 20);
			this.idCheck.Name = "idCheck";
			this.idCheck.Size = new System.Drawing.Size(53, 23);
			this.idCheck.TabIndex = 10;
			this.idCheck.Text = "check";
			this.idCheck.UseVisualStyleBackColor = true;
			this.idCheck.Click += new System.EventHandler(this.IdCheckClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(17, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 11;
			this.label5.Text = "비번확인";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(17, 62);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 12);
			this.label6.TabIndex = 12;
			this.label6.Text = "비밀번호";
			// 
			// txtPw2
			// 
			this.txtPw2.Location = new System.Drawing.Point(80, 84);
			this.txtPw2.Name = "txtPw2";
			this.txtPw2.PasswordChar = '*';
			this.txtPw2.Size = new System.Drawing.Size(100, 21);
			this.txtPw2.TabIndex = 13;
			// 
			// txtPw1
			// 
			this.txtPw1.Location = new System.Drawing.Point(80, 57);
			this.txtPw1.Name = "txtPw1";
			this.txtPw1.PasswordChar = '*';
			this.txtPw1.Size = new System.Drawing.Size(100, 21);
			this.txtPw1.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(17, 25);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 12);
			this.label7.TabIndex = 15;
			this.label7.Text = "아이디";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(80, 20);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 21);
			this.txtId.TabIndex = 16;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.idCheck);
			this.groupBox1.Controls.Add(this.txtPw2);
			this.groupBox1.Controls.Add(this.btnCancel);
			this.groupBox1.Controls.Add(this.btnJoin);
			this.groupBox1.Controls.Add(this.txtPw1);
			this.groupBox1.Controls.Add(this.txtId);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(8, 131);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(266, 124);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "회원 가입";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(208, 94);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(72, 16);
			this.checkBox1.TabIndex = 18;
			this.checkBox1.Text = "회원가입";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(210, 110);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(62, 18);
			this.button3.TabIndex = 19;
			this.button3.Text = "conn";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(281, 266);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "로그인";
			this.Load += new System.EventHandler(this.LoginLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
