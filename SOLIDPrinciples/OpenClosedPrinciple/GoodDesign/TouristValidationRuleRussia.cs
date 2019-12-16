using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.GoodDesign
{
    public class TouristValidationRuleRussia  : ITouristValidationRule
    {
        public string Country { get; set; }
        public int PassportSerialLength { get; set; }
        public int PassportNumberLength { get; set; }
        public bool ValidateRule()
        {
            return PassportSerialLength == 4 || PassportNumberLength == 8;
        }
    }
}
