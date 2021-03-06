﻿using System;
using System.IO;
using System.Windows.Forms;

namespace SamFirm
{
    internal static class Logger
    {
        public static MainForm Form { get; set; }

        //현재 날짜와 시각을 알아내는 함수
        private static string GetTimeDate()
        {
            return DateTime.Now.ToString("yyyy/MM/dd") + " " + DateTime.Now.ToString("HH:mm:ss");
        }

        //로그를 파일로 저장하는 메소드
        public static void SaveLog()
        {
            if (!string.IsNullOrEmpty(Form.Log_textbox.Text))
            {
                using (TextWriter writer = new StreamWriter(new FileStream("SamFirm.log", FileMode.Create)))
                {
                    writer.WriteLine(GetTimeDate());
                    foreach (string str in Form.Log_textbox.Lines)
                    {
                        writer.WriteLine(str);
                    }
                }
            }
        }

        //로그 텍스트 박스에 문자열을 출력하는 메소드
        public static void WriteLine(string str)
        {
            if (Form.Log_textbox.InvokeRequired)
            {
                MethodInvoker method = delegate
                {
                    Form.Log_textbox.AppendText(str + "\n");
                    Form.Log_textbox.ScrollToCaret();
                };
                Form.Log_textbox.Invoke(method);
            }
            else
            {
                Form.Log_textbox.AppendText(str + "\n");
                Form.Log_textbox.ScrollToCaret();
            }
        }
    }
}