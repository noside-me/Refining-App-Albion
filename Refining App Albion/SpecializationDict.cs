using System.Collections.Generic;

namespace Refining_App_Albion
{
    public class SpecializationDict
    {
        public Dictionary<string, int> Specs = new Dictionary<string, int>();

        public int this[string key]
        {
            get => Specs[key];
            set => Specs[key] = value;
        }

    }
}