using System;
namespace Program_Case{
    class Sistem_Case{
        static void Main(String[] args){
            Console.WriteLine("-----------------");
            Console.WriteLine("Silahkan pilih salah satu 1, 2, 3, 4");
            Console.WriteLine("Silahkan Input Pilihan: ");
            int menu = Convert.ToInt16(Console.ReadLine());
            switch(menu){
                case 1:
                Console.WriteLine("1. Paket Internet Bulanan");
                break;
                case 2:
                Console.WriteLine("2. Paket Internet Harian");
                break;
                case 3:
                Console.WriteLine("3. Paket Internet Hemat Habis");
                break;
                case 4:
                Console.WriteLine("4. Paket Internet Malam");
                break;
                default:
                Console.WriteLine("Anda Belum Memilih");
                break;
            }
            Console.WriteLine ("Anda memilih no {0}", menu);
            Console.WriteLine("-----------------");
        }
    }
}