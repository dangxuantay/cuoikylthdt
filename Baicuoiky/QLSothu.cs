using System;
using System.Collections.Generic;
using System.Text;

namespace Baicuoiky
{
    class QLSothu : QLThu
    {
        public void timthu()
        {
            string tim;
            Console.Write("Nhap thu can tim: ");
            tim = Console.ReadLine();
            if (tim == Ten)
            {
                Hienthithu();
            }
            else
                Console.WriteLine("Thu khong ton tai");
        }
    }
}
