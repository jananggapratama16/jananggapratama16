using System;
namespace pengecekandata{
    class cekdata{
        static void Main(string[] args){
            Console.WriteLine("=================================");
            Console.Write("apakah anda ingin login, ya / tidak : ");
            string? login = Console.ReadLine();
            Console.WriteLine("=================================");
                 if(login == "ya" || login == "YA" || login == "Ya"){
                    Console.WriteLine($"anda memilih {login}, dan berhasil masuk ke sistem");

                 } else if(login == "tidak" || login == "TIDAK" || login == "Tidak"){
                    Console.WriteLine($"anda memilih {login}, dan tidak berhak masuk ke sistem");
                 } else {
                    Console.WriteLine($"apa yang anda input{login}, tidak sesuai dan tidak berhak masuk ke sistem");

                 }
        }
    }
}