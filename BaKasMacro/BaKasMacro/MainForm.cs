/*
 * SharpDevelop으로 작성되었습니다.
 * 사용자: IJMAIL
 * 날짜: 2015-10-07
 * 시간: 오후 7:30
 * 
 * 이 템플리트를 변경하려면 [도구->옵션->코드 작성->표준 헤더 편집]을 이용하십시오.
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace BaKasMacro
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		void Button1Click(object sender, EventArgs e)
		{
			Process myProcess = new Process();
				
			ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(@"C:\Users\IJMAIL\AppData\Roaming\Nox\bin\nox_adb.exe" );
			myProcessStartInfo.Arguments = "devices";
			myProcessStartInfo.UseShellExecute = false;
			myProcessStartInfo.RedirectStandardOutput = true;		// 데이터 받기
			myProcessStartInfo.RedirectStandardError = true;		// 오류내용 받기
			myProcessStartInfo.CreateNoWindow = true;				// 원도우창 띄우기(true 띄우지 않기, false 띄우기)
			myProcess.StartInfo = myProcessStartInfo;
			myProcess.Start();
			myProcess.WaitForExit();
			
			//string output = myProcess.StandardOutput.ReadToEnd();
			string output = myProcess.StandardOutput.ReadToEnd();
			string error = myProcess.StandardError.ReadToEnd();
			string[] aa = output.Split('\n');
			
			for(int i=1; i<aa.Length; i++) {
				listBox1.Items.Add(aa[i]);
			}
			
			//listBox1.Items.Add(aa.Length);
			    
			//listBox1.Items.Add(aa[1]);
			
			//listBox1.Text = output;


            // 프로그램이 종료되면
            //System.Console.WriteLine( "ExitCode is " + myProcess.ExitCode );
            myProcess.WaitForExit();
            myProcess.Close();
			
		}
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ListBox1SelectedValueChanged(object sender, EventArgs e)
		{
			ListBox IbEvent = sender as ListBox;
			string aa = IbEvent.SelectedItem.ToString();
			
			textBox1.Text = aa;
		}

		
		/*
		// 마우스 클릭
		public void mmClick(int x, int y)
        {
            lock (process)
            {
                process.Start();

                process.StandardInput.Write("adb shell sendevent /dev/input/event7 1 330 1" + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 58 1" + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 53 " + x + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 54 " + y + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 0 2 0" + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 0 0 0" + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 1 330 0" + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 58 0" + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 53 " + x + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 54 " + y + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 0 2 0" + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 0 0 0" + Environment.NewLine);
                process.StandardInput.Close();

                process.WaitForExit();
                process.Close();
            }
        }

		// 에뮬에 드레그 메서드
		public void mmDrag(int x, int y, int x2, int y2)
        {
            lock (process)
            {
                process.Start();

                process.StandardInput.Write("adb shell sendevent /dev/input/event7 1 330 1" + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 58 1" + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 53 " + x + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 54 " + y + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 0 2 0" + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 0 0 0" + Environment.NewLine);

                int turm = (y - y2) / 5;

                for (int i = 0; i < 5; i++)
                {
                    y = y - turm;
                    Thread.Sleep(100);
                    process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 53 " + x + Environment.NewLine);
                    process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 54 " + y + Environment.NewLine);

                    process.StandardInput.Write("adb shell sendevent /dev/input/event7 0 2 0" + Environment.NewLine);
                    process.StandardInput.Write("adb shell sendevent /dev/input/event7 0 0 0" + Environment.NewLine);
                }
                Thread.Sleep(100);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 1 330 0" + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 58 0" + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 53 " + x + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 3 54 " + y2 + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 0 2 0" + Environment.NewLine);
                process.StandardInput.Write("adb shell sendevent /dev/input/event7 0 0 0" + Environment.NewLine);

                process.StandardInput.Close();

                process.WaitForExit(5000);
                process.Close();
            }
        }

		// 에뮬 캡쳐 메서드
		//꼭 파일스트림을 이용해 읽기 전용으로 가져올것...
		//에뮬과 같이 쓰기때문에 읽기전용으로 해야한다.

		public Bitmap mmCapture(int x, int y, int w, int h)
        {
            lock (process)
            {
                process.Start();

                Console.WriteLine("1. " + DateTime.Now.ToString("HH:mm:ss.fff"));
                process.StandardInput.Write("adb shell screencap -p /sdcard/download/cap.png" + Environment.NewLine);
                Console.WriteLine("2. " + DateTime.Now.ToString("HH:mm:ss.fff"));
                System.Threading.Thread.Sleep(1000);
                process.StandardInput.Write("adb pull /sdcard/download/cap.png" + Environment.NewLine);
                Console.WriteLine("3. " + DateTime.Now.ToString("HH:mm:ss.fff"));
                process.StandardInput.Write("adb shell rm /sdcard/download/cap.png" + x + Environment.NewLine);
                Console.WriteLine("4. " + DateTime.Now.ToString("HH:mm:ss.fff"));
                process.StandardInput.Close();
                Console.WriteLine("5. " + DateTime.Now.ToString("HH:mm:ss.fff"));
                process.WaitForExit();
                
                Console.WriteLine("6. " + DateTime.Now.ToString("HH:mm:ss.fff"));
                process.Close();

                FileStream stream = new FileStream(mWorkingDir + "\\cap.png", FileMode.Open);

                Bitmap bm = new Bitmap(stream);

                stream.Close();

                Rectangle recSource = new Rectangle(x, y, w, h);

                Bitmap bmpCropped = new Bitmap(w, h);

                Graphics grBitmap = Graphics.FromImage(bmpCropped);

                grBitmap.DrawImage(bm, 0, 0, recSource, GraphicsUnit.Pixel);

                return bmpCropped;
            }
        }
		
		public void mmConnect(string ip)
        {
            lock (process)
            {
                process.Start();

                process.StandardInput.Write("adb connect " + ip + Environment.NewLine);
                process.StandardInput.Close();

                process.WaitForExit();
                process.Close();
            }
        }

        public void mmDisconnect(string ip)
        {
            lock (process)
            {
                process.Start();
                                
                process.StandardInput.Write("adb disconnect " + ip + Environment.NewLine);
                process.StandardInput.Close();

                process.WaitForExit();
                process.Close();
            }
        }
		*/
		
	}	// MainForm Class End
}
