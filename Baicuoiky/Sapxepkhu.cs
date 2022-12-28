using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Baicuoiky
{
    class Sapxepkhu : IComparer<Khu>
    {
        public int Compare(Khu x, Khu y)
        {
            return x.makhu.CompareTo(y.makhu);
        }
    }
}
