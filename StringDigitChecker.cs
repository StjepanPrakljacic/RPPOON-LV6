using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPPOON_Lv6
{
    class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {

            if (stringToCheck.Any(char.IsDigit))
                return true;

            return false;
        }
    }
}
