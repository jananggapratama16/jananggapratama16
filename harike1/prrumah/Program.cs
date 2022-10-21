using System;
 namespace program_perhitungangaji{
    class program_perhitungangaji{
        static void Main(string[] args){
            int gaji_harian, hari_bekerja, hari_tidak_bekerja, hasil_gaji, gaji_sebelum_dipotong, potongan_gaji;

            Console.Write("gaji_harian : ");
            gaji_harian = Convert.ToInt32(Console.ReadLine());
            Console.Write("hari_bekerja : ");
            hari_bekerja = Convert.ToInt32(Console.ReadLine());
            Console.Write("hari_tidak_bekerja : ");
            hari_tidak_bekerja = Convert.ToInt32
            (Console.ReadLine()); 

            gaji_sebelum_dipotong = gaji_harian * hari_bekerja;
            potongan_gaji = hari_tidak_bekerja * gaji_harian;
            hasil_gaji = gaji_harian * hari_bekerja - potongan_gaji;

            Console.WriteLine("gaji sebelum dipotong : " + gaji_sebelum_dipotong);
            Console.WriteLine("potongan gaji : " + potongan_gaji);
            Console.WriteLine("gaji anda adalah : " + hasil_gaji);
        }
    }
 }