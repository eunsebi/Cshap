/*
 * SharpDevelop으로 작성되었습니다.
 * 사용자: IJMAIL
 * 날짜: 2015-10-11
 * 시간: 오후 1:59
 * 
 * 이 템플리트를 변경하려면 [도구->옵션->코드 작성->표준 헤더 편집]을 이용하십시오.
 */
using System;
using System.Diagnostics;

namespace test
{
	class Program
	{
		public static void Main(string[] args)
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
			
			// TODO: Implement Functionality Here
			
			Console.WriteLine(output);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}