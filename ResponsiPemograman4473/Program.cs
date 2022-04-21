using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karyawan
{
    public class Karyawan
    {
        //properties
        public int NikPaijo { get; set; }
        public int NikJono { get; set; }
        public string Nama1 { get; set; }
        public string Nama2 { get; set; }
        public float GajiBulanan1 { get; set; }
        public float GajiBulanan2 { get; set; }

        //method
        public void KaryawanInfo()
        {
            Console.WriteLine("Nik: {0}", NikPaijo);
            Console.WriteLine("Nik: {0}", NikJono);
            Console.WriteLine("Nama: {0}", Nama1);
            Console.WriteLine("Nama: {0}", Nama2);
            Console.WriteLine("GajiBulanan: {0}\n", GajiBulanan1);
            Console.WriteLine("GajiBulanan: {0}\n", GajiBulanan2);
        }
        public void KenaikanGaji()
        {
            Console.WriteLine("Nik: {0}", NikPaijo);
            Console.WriteLine("Nik: {0}", NikJono);
            Console.WriteLine("Nama: {0}", Nama1);
            Console.WriteLine("Nama: {0}", Nama2);
            Console.WriteLine("GajiBulanan: {0}\n", GajiBulanan1+30.000);
            Console.WriteLine("GajiBulanan: {0}\n", GajiBulanan2+20.000);
        }
       

    }
}
