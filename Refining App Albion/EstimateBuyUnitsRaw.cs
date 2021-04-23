using System;
using System.Collections.Generic;
using System.Text;

namespace Refining_App_Albion
{
    class EstimateBuyUnitsRaw
    {
        private double _rawMaterial;

        public double RawMaterial(double ifu, float resourceReturnRate)
        {
            _rawMaterial = ifu * (1 - resourceReturnRate);
            return _rawMaterial;
        }
    }
}
