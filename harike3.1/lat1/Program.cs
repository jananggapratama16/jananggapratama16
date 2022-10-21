using System;

namespace logika_if_else{
    class if_else{
        static void Main(string[] args){
            int angka = 9;
            if (angka < 9){
                Console.WriteLine($"nilai dari sistem : {angka} kurang dari ketentuan");
            }else if (angka > 9){
                Console.WriteLine($"nilai dari sistem : {angka} lebih dari ketentuan");
            }else if (angka == 9){
                Console.WriteLine($"nilai dari sistem : {angka} sama dengan ketentuan");
            }else {
                Console.WriteLine($"nilai dari sistem : {angka} tidak sesuai dari ketentuan/tidak valid");
            }

            }
        }
    }