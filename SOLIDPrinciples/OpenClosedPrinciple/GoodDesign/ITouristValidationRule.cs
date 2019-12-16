using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.GoodDesign
{
    public interface ITouristValidationRule
    {
        string Country { get; set; }
        int PassportSerialLength { get; set; }
        int PassportNumberLength { get; set; }

        bool ValidateRule();
    }
}
