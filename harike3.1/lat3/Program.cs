using System;

namespace Undian_Berhadiah{

    class Undian{

        static void Main(string[] args){

            int NoUndian = 0;

            Console.WriteLine("Undian Berhadiah Dari Sekolah MHS Dalam Acara Maulid Nabi");
            Console.Write("Silahakan Masukkan Nomor Undian Yang Diperoleh : ");
            NoUndian = Convert.ToInt16(Console.ReadLine());

            if(NoUndian == 19){
                Console.WriteLine($"Selamat, Nomor Undian Yang Anda Dapatkan, {NoUndian} , Anda Mendapatkan : 1 Mobil Remot!");
            }else if (NoUndian == 36){
                Console.WriteLine($"Selamat, Nomor Undian Yang Anda Dapatkan, {NoUndian} , Anda Mendapatkan : 1 Lusin Buku Bigbos!");
            }else if (NoUndian == 43){
                Console.WriteLine($"Selamat, Nomor Undian Yang Anda Dapatkan, {NoUndian} , Anda Mendapatkan : 1 buah Sepeda Motor!");
            }else if (NoUndian == 28){
                Console.WriteLine($"Selamat, Nomor Undian Yang Anda Dapatkan, {NoUndian} , Anda Mendapatkan : 1 buah Baju Kaos!");
            }else if (NoUndian == 32){
                Console.WriteLine($"Selamat, Nomor Undian Yang Anda Dapatkan, {NoUndian} , Anda Mendapatkan : Sebuah Helm LTD!");
            }else{
                Console.WriteLine($"Mohon Maaf Nomor Anda, {NoUndian} Anda tidak Beruntung, Silahkan Coba Lagi!");

            }
        }
    }
}