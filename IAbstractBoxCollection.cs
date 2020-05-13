using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_Lv6
{
    interface IAbstractBoxCollection
    {
        IAbstractBoxIterator GetIterator();
    }
}
