using System;
using System.Collections.Generic;
using System.Text;

namespace Refining_App_Albion
{
   
    class EstimateBuyUnitsRefined
    {
        private double _refinedMaterials;
        private readonly Dictionary<string, int> _refinedMaterialDict = new Dictionary<string, int>()
        {
            {"T4", 2 },
            {"T5", 3 },
            {"T6", 4 },
            {"T7", 5 },
            {"T8", 5 },
        };

        public double RefinedMaterial(string targetRefinedMaterial, double estimateRawMaterial)
        {
            _refinedMaterials = _refinedMaterialDict[targetRefinedMaterial] * estimateRawMaterial;
            return _refinedMaterials;
        }
    }
}
