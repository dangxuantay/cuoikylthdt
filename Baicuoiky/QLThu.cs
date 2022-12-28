using System;
using System.Collections.Generic;
using System.Text;

namespace Baicuoiky
{
    class QLThu : Thu
    {
        List<Thu> dv = new List<Thu>();
        public void Nhapthu()
        {
            string trl;
            Thu dvat;
            while (true)
            {
                dvat = new Thu();
                dvat.nhap();
                dv.Add(dvat);
                Console.Write("Ban muon nhap tiep thi nhan (y): ");
                trl = Console.ReadLine();
                if (trl != "y") break;
            }
        }
        public void Hienthithu()
        {
            foreach (Thu a in dv)
            {
                Console.WriteLine("Id thu: {0}", a.Idthu);
                Console.WriteLine("Loai thu: {0}", a.Loai);
                Console.WriteLine("Ten thu: {0}", a.Ten);
                Console.WriteLine("Tuoi thu: {0}", a.tuoi);
                Console.WriteLine("Ngay nuoi thu: {0}", a.Ngaynuoi);
                Console.WriteLine("Nguon goc thu: {0}", a.Nguongoc);
                Console.WriteLine("Suc khoe thu: {0}", a.Suckhoe);
                Console.WriteLine("Cach di chuyen thu: {0}", a.Dichuyen);
            }
        }
        public void Sapxepthu()
        {
            dv.Sort(new Sapxepthu());
        }
        
        
    }
}
