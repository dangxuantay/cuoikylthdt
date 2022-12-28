using System;
using System.Collections.Generic;
using System.Text;

namespace Baicuoiky
{
    class QLKhu : Khu
    {
        List<Khu> kh = new List<Khu>();
        public void Nhapkhu()
        {
            string trl;
            Khu Kh;
            while (true)
            {
                Kh = new Khu();
                Kh.Nhap();
                kh.Add(Kh);
                Console.Write("Ban muon nhap tiep thi nhan (y): ");
                trl = Console.ReadLine();
                if (trl != "y") break;
            }
        }
        public void Hienthikhu()
        {
            foreach (Khu a in kh)
            {
                Console.WriteLine("Ma khu: {0}", a.makhu);
                Console.WriteLine("Ten khu: {0}", a.Tenkhu);
            }
        }
        public void Sapxepkhu()
        {
            kh.Sort(new Sapxepkhu());
        }
    }
}
