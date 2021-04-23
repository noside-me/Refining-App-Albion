using System;
using System.Collections.Generic;
using System.Text;

namespace Refining_App_Albion
{
    class ResourceReturnRate
    {
        private readonly Dictionary<string, float> _withFocus = new Dictionary<string, float>()
        {
            {"RCB", .539f },
            {"RB", .435f },
            {"RIB", .497f },
            {"RI", .371f },
            {"BZ", .46f },
        };

        //private readonly Dictionary<string, float> _withoutFocus = new Dictionary<string, float>()
        //{
        //    {"RCB", .367f },
        //    {"RB", .152f },
        //    {"RIB", .285f },
        //    {"RI", .0f },
        //    {"BZ", .20f },
        //};

        public float BonusRate (string refiningLocation) /*(string focus, string refiningLocation)*/
        {
            //var bonus = 0f;
            //if ("Y" == focus)
            //    bonus = _withFocus[refiningLocation];
            //else if ("N" == focus)
            //    bonus = _withoutFocus[refiningLocation];

            //return bonus;

            return _withFocus[refiningLocation];
        }

    }
}
