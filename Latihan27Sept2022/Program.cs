using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan27Sept2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hari, bulan, tahun;
            Console.WriteLine("Menghitung Umur ....");
            Console.WriteLine("====================");

            try
            {
                Console.WriteLine("Masukkan tanggal");
                hari = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Masukkan bulan");
                bulan = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Masukkan tahun");
                tahun = Convert.ToInt32(Console.ReadLine());

                DateTime ultah = new DateTime(tahun, bulan, hari);
                DateTime hariini = DateTime.Now;

                TimeSpan umur = hariini.Subtract(ultah);
                Console.Write("Saat ini umur anda adalah : {0} hari, {1} jam, {2} menit", umur.Days, umur.Hours, umur.Minutes);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi kesalahan \n" + e.Message); ;
                Console.ReadLine();
            }
        }
    }
}
