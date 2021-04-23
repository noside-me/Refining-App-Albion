using System;

namespace Refining_App_Albion
{
    public class UserInput : InputManager
    {
        private string _tier;
        private string _specialization;
        private string _refinedMaterial;
        private string _tierEnchantment;
        private string _currentFocusPoints;
        private string _options;
        private string _refiningLocation;
        //private string _premiumFocusStatus;

        public string TierInput()
        {
            Console.Write("Tier: ");
            _tier = Console.ReadLine().ToUpper();
            if (_tier == "QUIT")
                QuitApp();
            else if (_tier == "RESET")
                ResetApp();
            return _tier;
        }

        public int SpecializationInput()
        {
            Console.Write("Specialization: ");
            _specialization = Console.ReadLine().ToUpper();
            if (Convert.ToString(_specialization) == "QUIT")
                QuitApp();
            else if (Convert.ToString(_specialization) == "RESET")
                ResetApp();
            Console.WriteLine("");
            return Convert.ToInt32(_specialization);
        }

        public string RefinedMaterial()
        {
            Console.Write("Tier to refine: ");
            _refinedMaterial = Console.ReadLine().ToUpper();
            if (_refinedMaterial == "QUIT")
                QuitApp();
            else if (_refinedMaterial == "RESET")
                ResetApp();
            Console.WriteLine("");
            return _refinedMaterial;
        }

        public string TierEnchantment()
        {
            Console.Write("Tier and enchantment: ");
            _tierEnchantment = Console.ReadLine().ToUpper();
            if (_tierEnchantment == "QUIT")
                QuitApp();
            else if (_tierEnchantment == "RESET")
                ResetApp();
            Console.WriteLine("");
            return _tierEnchantment;
        }

        public int CurrentFocusPoints()
        {
            Console.Write("Your current focus points: ");
            _currentFocusPoints = Console.ReadLine().ToUpper();
            if (_currentFocusPoints == "QUIT")
                QuitApp();
            else if (_currentFocusPoints == "RESET")
                ResetApp();
            Console.WriteLine("");
            return Convert.ToInt32(_currentFocusPoints);
        }

        public string RefiningLocation()
        {
            Console.Write(@"Refining Location.
For Royal City with Bonus, type RCB.
For Royal City without Bonus, type RC.
For Royal Island with Bonus, type RIB.
For Royal Island without Bonus, type RI.
For Black Zone HO, type BZ.

Type here: ");
            _refiningLocation = Console.ReadLine().ToUpper();
            if (_refiningLocation == "QUIT")
                QuitApp();
            else if (_refiningLocation == "RESET")
                ResetApp();
            Console.WriteLine("");
            return _refiningLocation;
        }

        public void Option()
        {
            Console.WriteLine("");
            Console.Write("Save/Reset/Quit? ");
            _options = Console.ReadLine().ToUpper();
            if (_options == "QUIT")
                QuitApp();
            else if (_options == "RESET")
                ResetApp();
            //else if (_options == "SAVE")
            //    Save();
            Console.WriteLine("");
        }

        //public string PremiumFocusStatus()
        //{
        //    Console.Write("Refine with focus or without focus, Y/N? ");
        //    _premiumFocusStatus = Console.ReadLine().ToUpper();
        //    if (_premiumFocusStatus == "QUIT")
        //        QuitApp();
        //    else if (_premiumFocusStatus == "RESET")
        //        ResetApp();
        //    Console.WriteLine("");
        //    return _premiumFocusStatus;
        //}
    }
}