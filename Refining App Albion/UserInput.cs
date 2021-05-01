using System;

namespace Refining_App_Albion
{
    public class UserInput : InputManager
    {
        private string _specialization;
        private string _refinedMaterial;
        private string _tierEnchantment;
        private string _currentFocusPoints;
        private string _refiningLocation;
        private string _optionEvent;

        public int SpecializationInput(string tierX)
        {
            
            Console.Write("Specialization of {0}: ", tierX);
            _specialization = Console.ReadLine().ToUpper();

            Option(_specialization);
            Console.WriteLine("");

            return Convert.ToInt32(_specialization);
        }

        public string RefinedMaterial()
        {
            Console.Write("Tier to refine: ");
            _refinedMaterial = Console.ReadLine().ToUpper();

            Option(_refinedMaterial);
            Console.WriteLine("");

            return _refinedMaterial;
        }

        public string TierEnchantment()
        {
            Console.Write("Tier and enchantment: ");
            _tierEnchantment = Console.ReadLine().ToUpper();

            Option(_tierEnchantment);
            Console.WriteLine("");

            return _tierEnchantment;
        }

        public int CurrentFocusPoints()
        {
            Console.Write("Your current focus points: ");
            _currentFocusPoints = Console.ReadLine().ToUpper();

            Option(_currentFocusPoints);
            Console.WriteLine("");

            return Convert.ToInt32(_currentFocusPoints);
        }

        public string RefiningLocation()
        {
            Console.Write(@"Refining Location.
For Royal City with Bonus, type RCB.
For Royal City without Bonus, type RB.
For Royal Island with Bonus, type RIB.
For Royal Island without Bonus, type RI.
For Black Zone HO, type BZ.

Type here: ");
            _refiningLocation = Console.ReadLine().ToUpper();

            Option(_refiningLocation);
            Console.WriteLine("");

            return _refiningLocation;
        }

        public void Option(string option)
        {
            if ("-Q" == option)
                QuitApp();
            else if ("-R" == option)
                ResetApp();
            else if ("-S" == option)
                Save();
            else
                return;
        }

        public void OptionEvent()
        {
            Console.Write("Save/Reset/Quit? ");
            _optionEvent = Console.ReadLine().ToUpper();
            Option(_optionEvent);

        }
    }
}