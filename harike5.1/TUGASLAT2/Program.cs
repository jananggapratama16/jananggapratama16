using System;
namespace InputanArray{
    class DataInput{
        static void Main(string[] args){
            int JmlArray;
            Console.WriteLine("=============================================");
            Console.Write("Silahkan Input Banyak Junlah Array :");
            JmlArray = Convert.ToInt16(Console.ReadLine());
            // menentukan nilai inputan string
            string? [] NamaTeman = new string[JmlArray];
            // menentukan inputan data menjadi array
            for(int nAwal=0; nAwal < JmlArray; nAwal++){
                Console.Write("Silahkan Input Nama Teman Anda : ");
                NamaTeman[nAwal] = Console.ReadLine();

            }
            Console.WriteLine("===================================================");
            Console.WriteLine("Daftar Nama Teman Yang Sudah Diinput :");
            for(int nIndex = 0; nIndex < JmlArray; nIndex++){
                System.Console.Write("Nama Ke Indek : " + nIndex); 
                Console.WriteLine("    Daftar Nama Teman : "  + NamaTeman[nIndex]);
            }
            Console.WriteLine("=====================================================");
            Console.ReadLine();

        }
    }
}