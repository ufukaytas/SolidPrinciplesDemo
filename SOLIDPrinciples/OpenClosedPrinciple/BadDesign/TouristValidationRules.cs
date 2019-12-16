using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.BadDesign
{
    class TouristValidationRules
    {
        public bool Validate(string country, int passportSerialLength, int passportNumberLength  )
        {
            bool result = false;

            switch (country)
            {
                case "Turkey":
                    // Validate passportSerialLength and  passportNumberLength for Turkey
                    break;
                case "Russia":
                    // Validate passportSerialLength and  passportNumberLength for Russia
                    break;
            }

            return result;
        }  
    }
}
