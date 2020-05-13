using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_Lv6
{
    class StringLengthChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            for (int i = 0; i < stringToCheck.Length; i++)
            {
                if (i == 10)
                    return true;
            }
            return false;
        }
    }
}
