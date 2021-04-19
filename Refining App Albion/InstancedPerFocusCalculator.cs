namespace Refining_App_Albion
{
    public class InstancedPerFocusCalculator
    {
        private double _ifu; //instanced per focus used
        public double IFUCalculate(int focusPoints, double focusCost)
        {
            _ifu = focusPoints / focusCost;
            return _ifu;
        }
    }
}