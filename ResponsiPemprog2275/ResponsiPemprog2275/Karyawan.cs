using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemprog2275
{
    public class Karyawan
    {
        public Karyawan()
        {

        }

        public Karyawan(string Nik, string Nama, int Gajibulanan)
        {
            if (Gajibulanan < 0)
            {
                Console.WriteLine ("gaji harus di atas 0");
            }
            else
            {
                nik = Nik;
                nama = Nama;
                gajibulanan = Gajibulanan;
            }
        }

        public string nik { get; set; }
        public string nama { get; set; }
        public int gajibulanan { get; set; }

    }
}
