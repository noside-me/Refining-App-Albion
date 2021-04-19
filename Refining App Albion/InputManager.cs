using System;
using System.Threading;

namespace Refining_App_Albion
{
    public class InputManager
    {
        public void ResetApp()
        {

        }

        public void QuitApp()
        {
            Thread.Sleep(5000);
            Environment.Exit(0);
        }
    }
}