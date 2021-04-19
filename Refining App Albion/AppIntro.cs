using System;

namespace Refining_App_Albion
{
    public class AppIntro
    {
        private readonly string _intro = @"Type:
Tx/tx = tier e.g T4 or t4;
Specialization = just input your current specs starting from t4-t8;
Save/save = save your data to a text file;
Reset/reset = restart your data input;
Quit/quit = terminate the app;
";

        public void Intro()
        {
            Console.WriteLine(_intro);
        }
    }
}