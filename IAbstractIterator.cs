using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_Lv6
{
    interface IAbstractIterator
    {
        Note First();
        Note Next();
        bool IsDone { get; }
        Note Current { get; }
    }
}
