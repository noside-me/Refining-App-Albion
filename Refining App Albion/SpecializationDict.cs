using System.Collections.Generic;

namespace Refining_App_Albion
{
    public class SpecializationDict
    {
        public Dictionary<string, int> Specs = new Dictionary<string, int>() 
        { 
            {"T4", 0},
            {"T5", 0},
            {"T6", 0},
            {"T7", 0},
            {"T8", 0},
        };

        public int this[string key]
        {
            get => Specs[key];
            set => Specs[key] = value;
        }
    }
}