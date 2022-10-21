using System;

class InputanManual{
    public static void Main (string [] args){
        double alas, tinggi, hasil;

        Console.Write("alas = ");
        alas = Convert.ToInt16(Console.ReadLine());
        Console.Write("tinggi = ");
        tinggi = Convert.ToInt16(Console.ReadLine());

        hasil = 0.5 * alas * tinggi;

        Console.WriteLine ("Hasilnya adalah : " + hasil);
    }
}