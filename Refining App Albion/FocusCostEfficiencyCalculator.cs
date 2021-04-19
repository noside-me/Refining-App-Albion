using System;

namespace Refining_App_Albion
{
    public class FocusCostEfficiencyCalculator
    {
        private int _masteryEfficiency;
        private int _specializationEfficiency;
        private int _totalFocusCostEfficiency;

        public int MasteryCalculator(int t4, int t5, int t6, int t7, int t8)
        {
            _masteryEfficiency = 30 * (t4 + t5 + t6 + t7 + t8);
            return _masteryEfficiency;
        }

        public int SpecializationCalculator(int refinedMats)
        {
            _specializationEfficiency = 250 * refinedMats;
            return _specializationEfficiency;
        }

        public int TotalFocusEffCalc(int mastery, int specs)
        {
            _totalFocusCostEfficiency = mastery + specs;
            return _totalFocusCostEfficiency;
        }
        
    }
}