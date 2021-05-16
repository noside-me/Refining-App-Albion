using System;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

namespace Refining_App_Albion
{
    public class InputManager
    {
        private string _dirParam = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"Refining App\RefineOutput.txt");
        private string _param = Path.Combine(AppDomain.CurrentDomain.FriendlyName, @"Refining App\RefineOutput.txt");
        private readonly string _intro = @"=============
Legend:
Specialization: Input your current specs starting from t4-t8;
-s = Save your data to a text file;
-r = Restart at the beginning of data input;
-q = Terminate the app;
-h = Help info;
=============
";

        //public void Logger(string rawMaterial, double rawMatInt, double refinedMatInt)
        //{
        //    var tier = new Dictionary<string, string>()
        //    {
        //        {"T4","T3"},
        //        {"T5","T4"},
        //        {"T6","T5"},
        //        {"T7","T6"},
        //        {"T8","T7"},
        //    };

        //}

        public void Intro()
        {
            Console.WriteLine(_intro);
        }

        public void Save()
        {
            var fParameter = new FileStream(_dirParam, FileMode.Create, FileAccess.Write);
            var m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write("this is the saved message.");
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
        }

        public void ResetApp()
        {
            Process.Start(AppDomain.CurrentDomain.FriendlyName);
            Environment.Exit(0);
        }

        public void QuitApp()
        {
            Thread.Sleep(10000);
            Environment.Exit(0);
        }
    }
}