using System;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Refining_App_Albion
{
    public class InputManager
    {
        public void Save(string text1, string text2)
        {
            var path = @"C:\testfile\Output.txt";
            var rawMatString = @"Your targer estimate of raw materials is: ";
            var refinedMatString = @"Low tier refined materials needed: ";
            var textFile = new string[2] { rawMatString + text1, refinedMatString + text2};
            File.WriteAllLines(path, textFile);
        }

        public void ResetApp()
        {
            Process.Start(AppDomain.CurrentDomain.FriendlyName);
            Environment.Exit(0);
        }

        public void QuitApp()
        {
            Thread.Sleep(0000);
            Environment.Exit(0);
        }
    }
}