using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_Lv6
{
    interface IAbstractBoxIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
