using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.GoodDesign
{
    class TouristValidationRuleTurkey : ITouristValidationRule
    {
        public string Country { get; set; }
        public int PassportSerialLength { get; set; }
        public int PassportNumberLength { get; set; }
        public bool ValidateRule()
        {
            return PassportSerialLength == 3 || PassportNumberLength == 7;
        }
    }
}
