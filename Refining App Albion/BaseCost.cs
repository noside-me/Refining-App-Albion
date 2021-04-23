using System.Collections.Generic;

namespace Refining_App_Albion
{
    public class BaseCost
    {
        private readonly Dictionary<string, int> _baseCost;

        public BaseCost()
        {
            _baseCost = new Dictionary<string, int>()
            {
                {"4.0",48},
                {"4.1", 89},
                {"4.2", 143},
                {"4.3", 239},
                {"5.0", 89},
                {"5.1", 160},
                {"5.2", 269},
                {"5.3", 461},
                {"6.0", 160},
                {"6.1", 284},
                {"6.2", 487},
                {"6.3", 844},
                {"7.0", 284},
                {"7.1", 500},
                {"7.2", 866},
                {"7.3", 1508},
                {"8.0", 500},
                {"8.1", 877},
                {"8.2", 1527},
                {"8.3", 2666},
            };
        }

        public int this[string key]
        {
            get => _baseCost[key];
            set => _baseCost[key] = value;
        }
    }
}