using System;
using System.Runtime.InteropServices;

namespace Refining_App_Albion
{
    public class FocusCostCalculator
    {
        private const double HalfInteger = 0.5;
        private const double TenKConstant = 10000;
        private double _focusCost;

        public double FocusCostCalculate(int baseCost, int focusCostEfficiency)
        {
            _focusCost = baseCost * (Math.Pow(HalfInteger, (focusCostEfficiency / TenKConstant)));
            return _focusCost;
        }
    }
}