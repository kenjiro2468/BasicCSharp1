using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int angka1, angka2, hasil;
            //Console.WriteLine("Silahkan masukan angka pertama");
            //angka1 = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Silahkan masukan angka kedua");
            //angka2 = int.Parse(Console.ReadLine());

            //hasil = angka1 + angka2;

            //Console.WriteLine(hasil);

            string nama, asal;
            Console.WriteLine("Masukan Nama : ");
            nama = Console.ReadLine();
            Console.WriteLine("Masukan asal : ");
            asal = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hallo {0} dari {1} Selamat datang di C#", nama,asal);
        }
    }
}
