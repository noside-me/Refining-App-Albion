using System;

namespace Refining_App_Albion
{
    public class AppIntro
    {
        private readonly string _intro = @"=============
Legend:
Specialization: Input your current specs starting from t4-t8;
-s = Save your data to a text file;
-r = Restart at the beginning of data input;
-q = Terminate the app;
-h = Help info;
=============
";

        public void Intro()
        {
            Console.WriteLine(_intro);
        }
    }
}