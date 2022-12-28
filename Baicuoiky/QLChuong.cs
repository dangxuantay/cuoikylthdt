using System;
using System.Collections.Generic;
using System.Text;

namespace Baicuoiky
{
    class QLChuong : Chuong
    {
        List<Chuong> ch = new List<Chuong>();        
        public void Nhapchuong()
        {
            string trl;
            Chuong Ch;
            while (true)
            {
                Ch = new Chuong();
                Ch.Nhap();
                ch.Add(Ch);
                Console.Write("Ban muon nhap tiep thi nhan (y): ");
                trl = Console.ReadLine();
                if (trl != "y") break;
            }
        }
        public void Hienthichuong()
        {
            foreach (Chuong a in ch)
            {
                Console.WriteLine("ID Chuong: {0}", IDchuong);
                Console.WriteLine("Ten Chuong: {0}", Tenchuong);

            }
        }
        public void Sapxepchuong()
        {
            ch.Sort(new Sapxepchuong());
        }
    }
}
