using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karyawan
{
    public class Program
    {
        static void Main(String[]args)
        {
            Karyawan karyawan = new Karyawan();

            karyawan.NikPaijo = 190302123;
            karyawan.NikJono = 190302124;
            karyawan.Nama1 = "Paijo";
            karyawan.Nama2 = "Jono";
            karyawan.GajiBulanan1 = 3000000;
            karyawan.GajiBulanan2 = 2000000;

            karyawan.KaryawanInfo();
            karyawan.KenaikanGaji();
        }
    }
}
