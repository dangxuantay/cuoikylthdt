using System;
using System.Collections.Generic;
using System.Text;

namespace Baicuoiky    
{
    class Program
    {
        static void Main(string[] args)
        {
            QLKhu ds = new QLKhu();
            ds.Hienthikhu();
            Khu khuABC = new Khu();
            khuABC.Nhap();
            khuABC.Xuat();
            Console.WriteLine();
        }
    }

    
    
    interface IKhu
    {
        int makhu { get; set; }
        string Tenkhu { get; set; }
        void Nhap();
        void Xuat();
    }
    class Khu : IKhu
    {
        public string Tenkhu { get; set; }
        public int makhu { get; set; }

        public void Nhap()
        {
            Console.Write("Nhap ten khu: ");
            makhu = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten khu: ");
            Tenkhu = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("Ma khu: {0}", makhu);
            Console.WriteLine("Ten khu: {0}", Tenkhu);
        }
    }
}
