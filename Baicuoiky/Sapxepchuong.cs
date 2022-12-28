using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Baicuoiky
{
    class Sapxepchuong : IComparer<Chuong>
    {
        public int Compare(Chuong x, Chuong y)
        {
            return x.IDchuong.CompareTo(y.IDchuong);            
        }
    }
}
