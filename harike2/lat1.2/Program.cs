using System;
namespace perulangan_for{
    class programfor{
        static void Main (String [] args){
            int v1, v2 = 0;

            Console.Write("input bilangan pertama :");
            v1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("input bilangan kedua :");
            v2 = Convert.ToInt16(Console.ReadLine());

            for (int pertama = v1; pertama < v2; pertama = pertama + 1){
            Console.WriteLine("Hasil Pengulangan ke: {0}", pertama);
            }
            Console.ReadLine();
        }
    }
}