using System;

namespace Baicuoiky
{
    class Program
    {
        static void Main(string[] args)
        {
            QLNV ds = new QLNV();
            ds.Hienthinv();
            Nhanvien nhanviena = new Nhanvien();
            Nhanvien nhanvienb = new Nhanvien();
            nhanviena.hienthi();
            Console.WriteLine();
        }
    }
}
