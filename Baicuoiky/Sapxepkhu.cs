using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Baicuoiky
{
        class Sapxepkhu:Khu
    {
        public int Compare(Khu x, Khu y)
        {
            int a = x.Tenkhu.CompareTo(y.Tenkhu);
            if (a == 0)
                return x.makhu.CompareTo(y.makhu);
            return a;
        }
    }
}
