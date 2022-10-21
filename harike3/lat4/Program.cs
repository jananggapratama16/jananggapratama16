using System;

namespace PerulanganObjek{

    class Objek{

        static void Main(string[] args){

            int banyakbintang, batas1, batas2;

            Console.Write("SILAKAN MASUKKAN PANJANG ALAS DARI SEGITIGA : ");
            banyakbintang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("========================================================================================================");

            for(batas1 = 0; batas1 < banyakbintang; batas1++){
                for (batas2 = 0; batas2 <= batas1; batas2++){
                    Console.Write("*");
                } Console.WriteLine();
            } Console.WriteLine();
        }
        }
    }