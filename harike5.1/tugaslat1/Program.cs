using System;
namespace TipeArray{
    class Array{
        static void UjiCobaArray(int[,] Array){
            for (int nAwal = 0; nAwal < Array.GetLength(0); nAwal++){
                for (int nAkhir = 0; nAkhir < Array.GetLength(1); nAkhir++){
                    System.Console.WriteLine ("Data Index Elemen Ke : ({0} , {1}, {2}) = {2}" , nAwal, nAkhir, Array[nAwal, nAkhir]);
                }
        
            }
        }
        static void Main(string[] args){
            UjiCobaArray(new int[,]{{1,5,7},{4,3,9},{7,1,3},{2,8,4},{3,3,4},{7,4,3},{3,1,3}});
            System.Console.WriteLine("Tekan Bebas Untuk Keluar Halaman Kerja ! ");
            System.Console.ReadKey();
        }
    }
}