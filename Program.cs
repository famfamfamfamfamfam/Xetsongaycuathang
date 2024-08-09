using System;
using System.Runtime.InteropServices;
namespace SUDUNGSWITCHCASE
{
    class DemSoNgayCuaThang
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thang can xet:");
            int thang = int.Parse(Console.ReadLine());
            string songay = "";
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: songay = "31"; break;
                case 2: songay = "28 hoac 29"; break;
                case 4:
                case 6:
                case 9:
                case 11: songay = "30"; break;
                default: Console.WriteLine("Thang khong hop le"); break;
            }
            if (thang<=12&&thang>=1)
            {
                Console.WriteLine("Thang {0} co {1} ngay", thang, songay);
            }
        }
    }
}