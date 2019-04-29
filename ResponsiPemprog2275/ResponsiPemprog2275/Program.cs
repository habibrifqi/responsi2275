using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemprog2275
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kry1 = new Karyawan("1234567","habib",2000000);


            Karyawan kry2 = new Karyawan("1234567","rifqi",1000000);


            Console.WriteLine("No NIK/NAMA \t\tGajibulanan");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1.{0} {1}\t\t{2}", kry1.nik, kry1.nama, kry1.gajibulanan);
            Console.WriteLine("2.{0} {1}\t\t{2}", kry2.nik, kry2.nama, kry2.gajibulanan);

            Console.WriteLine("\n\n");
            Console.WriteLine("asik naik gaji 10%");
            Console.WriteLine("1.{0} {1}\t\t{2}", kry1.nik, kry1.nama, kry1.gajibulanan +(kry1.gajibulanan * 0.10));
            Console.WriteLine("2.{0} {1}\t\t{2}", kry2.nik, kry2.nama, kry2.gajibulanan + (kry2.gajibulanan * 0.10));
            Console.ReadKey();



        }


    }
}
