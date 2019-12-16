using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.GoodDesign
{
    class TouristValidationRules
    {
        public bool Validate(ITouristValidationRule rule)
        {
            var result = rule.ValidateRule();

            return result;
        }
    }
}
