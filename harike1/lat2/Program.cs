using System;

class InputanManual{
    public static void Main (string [] args){
        int bilangan1, Bilangan2, hasil, hasil2, hasil3;

        Console.Write("Bilangan 1 = ");
        bilangan1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Bilangan 2 = ");
        Bilangan2 = Convert.ToInt16(Console.ReadLine());

        hasil = bilangan1 + Bilangan2;
        hasil2 = bilangan1 - Bilangan2;
        hasil3 = bilangan1 * Bilangan2;
        
        Console.WriteLine ("Hasilnya adalah : " + hasil);
        Console.WriteLine ("Hasilnya adalah : " + hasil2);
        Console.WriteLine ("Hasilnya adalah : " + hasil3);
    }
}