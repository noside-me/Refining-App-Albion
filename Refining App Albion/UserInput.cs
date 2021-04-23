using System;

namespace Refining_App_Albion
{
    public class UserInput : InputManager
    {
        private string _specialization;
        private string _refinedMaterial;
        private string _tierEnchantment;
        private string _currentFocusPoints;
        private string _options;
        private string _refiningLocation;

        public int SpecializationInput(string tierX)
        {
            
            Console.Write("Specialization of {0}: ", tierX);
            _specialization = Console.ReadLine().ToUpper();
            if (Convert.ToString(_specialization) == "-Q")
                QuitApp();
            else if (Convert.ToString(_specialization) == "-R")
                ResetApp();
            Console.WriteLine("");
            return Convert.ToInt32(_specialization);
        }

        public string RefinedMaterial()
        {
            Console.Write("Tier to refine: ");
            _refinedMaterial = Console.ReadLine().ToUpper();
            if (_refinedMaterial == "-Q")
                QuitApp();
            else if (_refinedMaterial == "-R")
                ResetApp();
            Console.WriteLine("");
            return _refinedMaterial;
        }

        public string TierEnchantment()
        {
            Console.Write("Tier and enchantment: ");
            _tierEnchantment = Console.ReadLine().ToUpper();
            if (_tierEnchantment == "-Q")
                QuitApp();
            else if (_tierEnchantment == "-R")
                ResetApp();
            Console.WriteLine("");
            return _tierEnchantment;
        }

        public int CurrentFocusPoints()
        {
            Console.Write("Your current focus points: ");
            _currentFocusPoints = Console.ReadLine().ToUpper();
            if (_currentFocusPoints == "-Q")
                QuitApp();
            else if (_currentFocusPoints == "-R")
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
            if (_refiningLocation == "-Q")
                QuitApp();
            else if (_refiningLocation == "-R")
                ResetApp();
            Console.WriteLine("");
            return _refiningLocation;
        }

        public void Option()
        {
            Console.WriteLine("");
            Console.Write("Save/Reset/Quit? ");
            _options = Console.ReadLine().ToUpper();
            if (_options == "-Q")
                QuitApp();
            else if (_options == "-R")
                ResetApp();
            //else if (_options == "SAVE")
            //    Save();
            Console.WriteLine("");
        }
    }
}