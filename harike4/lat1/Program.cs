using System;
namespace SistemPendaftaran{
    class daftarmhs{
        public static void Main(string[] args){
            string? nama;
            int semester = 6, menu, harga, biayasemester, diskon, totalbayar, NilaiUAN;
            Console.WriteLine("============================================================");
            Console.WriteLine("=\t\tSelamat Datang Di Smk Multistudi High School Batam\t\t\t:");
            Console.WriteLine("=\t\tPara Calon Siswa MHS KELAS X JURUSAN TKJ, RPL\t\t\t:");
            Console.WriteLine("============================================================");
            Console.WriteLine(" ");
            Console.Write("Masukkan Nama Calon Siswa \t\t:");
            nama = Console.ReadLine();
            Console.Write("Masukkan Asal sekolah \t\t:");
            var asalsekolah = Console.ReadLine();
            Console.Write("Masukkan Nilai UAN \t\t:");
            NilaiUAN = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("============================================================");
            Console.WriteLine("1. TKJ \t=Rp. 500.000/bulan");
            Console.WriteLine("2. RPL \t=Rp. 600.000/bulan");
            Console.WriteLine("3. AKUTANSI \t=Rp. 450.000/bulan");
            Console.WriteLine("4. SENI TARI \t=Rp. 550.000/bulan");
            Console.WriteLine("5. MULTIMEDIA \t=Rp. 400.000/bulan");
            Console.WriteLine("SILAHKAN PILIH JURUSAN YANG ANDA MINATI :");
 
            menu = Convert.ToInt16(Console.ReadLine());
            switch(menu){
                case 1:
                biayasemester = 500000; 
                harga = semester * biayasemester;
                if(NilaiUAN > 80){
                    diskon = biayasemester * 15/100;
                }else{
                    diskon = 0;

                }
                totalbayar = harga - diskon;
                Console.WriteLine("Data Calon Siswa");
                Console.WriteLine("Nama Calon Siswa : " + nama);
                Console.WriteLine("Nama Asal Sekolah : " + asalsekolah);
                Console.WriteLine("Nilai UAN SMP : " + NilaiUAN);
                Console.WriteLine("Jumlah Semester Selama 3 Tahun : " + semester);
                Console.WriteLine("Harga Sebelum Mendapatkan Diskon : " + harga);
                Console.WriteLine("diskon diperoleh jika Nilai UAN >= 85 : maka akan mendapatkan diskon : " + diskon);
                Console.WriteLine("total biaya yang harus dibayarkan : " + totalbayar);
                Console.ReadKey();
        
        break;
           }
        }
    }
}