using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Common
{
    public class Terbilang
    {
        static String[] nomina ={"","Satu","Dua","Tiga","Empat","Lima","Enam",
                         "Tujuh","Delapan","Sembilan","Sepuluh","Sebelas"};

        public static String Bilang(decimal angka)
        {
            if (angka < 12)
            {
                return nomina[(int)angka];
            }

            if (angka >= 12 && angka <= 19)
            {
                return nomina[(int)angka % 10] + " Belas ";
            }

            if (angka >= 20 && angka <= 99)
            {
                return nomina[(int)angka / 10] + " Puluh " + nomina[(int)angka % 10];
            }

            if (angka >= 100 && angka <= 199)
            {
                return "Seratus " + Bilang(angka % 100);
            }

            if (angka >= 200 && angka <= 999)
            {
                return nomina[(int)angka / 100] + " Ratus " + Bilang(angka % 100);
            }

            if (angka >= 1000 && angka <= 1999)
            {
                return "Seribu " + Bilang(angka % 1000);
            }

            if (angka >= 2000 && angka <= 999999)
            {
                return Bilang((int)angka / 1000) + " Ribu " + Bilang(angka % 1000);
            }

            if (angka >= 1000000 && angka <= 999999999)
            {
                return Bilang((int)angka / 1000000) + " Juta " + Bilang(angka % 1000000);
            }

            return "";
        }
    }
}
