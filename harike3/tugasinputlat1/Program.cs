using System;
namespace logikaifelse{
    class ifelse{
        static void Main(string[] args){
            int angka, sama;
            Console.Write("masukkan angka = ");
            angka = Convert.ToInt32(Console.ReadLine());
            Console.Write("masukkanlah angka kelebihan || kekurangan dan kesamaan = ");
            sama = Convert.ToInt32(Console.ReadLine());
            if ( angka < sama){
                Console.WriteLine($"nilai dari : {angka} kurang dari yang ditentukan");
            }else if ( angka > sama){ 
                Console.WriteLine($"nilai dari : {angka} lebih dari yang ditentukan");
            }else if ( angka == sama){ 
                Console.WriteLine($"nilai dari : {angka} sama dengan ketentuan");
            }else{ 
                Console.WriteLine($"nilai dari : {angka} tidak sesuai dengan yang ditentukan");
            }

             
            
        }
    }
}