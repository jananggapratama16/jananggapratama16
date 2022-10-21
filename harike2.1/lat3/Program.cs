using System;
namespace Loops{
   class Program   {
      static void Main(string[] args)      {
         int permulaan = 8;
         do  {
            Console.WriteLine("Perulangan do dan While k: {0}", permulaan);
            permulaan = permulaan + 1;
         } 
         while (permulaan < 20) ;
         Console.ReadLine();
      }
   }
}