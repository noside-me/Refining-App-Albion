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

        public string TierInput()
        {
            Console.Write("Tier: ");
            _tier = Console.ReadLine().ToUpper();
            if (_tier == "QUIT")
                QuitApp();
            return _tier;
        }

        public int SpecializationInput()
        {
            Console.Write("Specialization: ");
            _specialization = Console.ReadLine().ToUpper();
            if (Convert.ToString(_specialization) == "QUIT")
                QuitApp();
            Console.WriteLine("");
            return Convert.ToInt32(_specialization);
        }

        public string RefinedMaterial()
        {
            Console.Write("Tier to refine: ");
            _refinedMaterial = Console.ReadLine().ToUpper();
            if (_refinedMaterial == "QUIT")
                QuitApp();
            Console.WriteLine("");
            return _refinedMaterial;
        }

        public string TierEnchantment()
        {
            Console.Write("Tier and enchantment: ");
            _tierEnchantment = Console.ReadLine().ToUpper();
            if (_tierEnchantment == "QUIT")
                QuitApp();
            Console.WriteLine("");
            return _tierEnchantment;
        }

        public int CurrentFocusPoints()
        {
            Console.Write("Your current focus points: ");
            _currentFocusPoints = Console.ReadLine().ToUpper();
            if (_currentFocusPoints == "QUIT")
                QuitApp();
            Console.WriteLine("");
            return Convert.ToInt32(_currentFocusPoints);
        }

        public void Option()
        {
            Console.WriteLine("");
            Console.Write("Save/Reset/Quit? ");
            _options = Console.ReadLine().ToUpper();
            if (_options == "QUIT")
            {
                QuitApp();
            }
        }
    }
}