using System;

namespace Refining_App_Albion
{
    public class AppIntro
    {
        private readonly string _intro = @"=============
Legend:
Tier = e.g T4 or t4;
Specialization = just input your current specs starting from t4-t8;
Save = save your data to a text file;
Reset = restart your data input;
Quit = terminate the app;
";

        public void Intro()
        {
            Console.WriteLine(_intro);
        }
    }
}