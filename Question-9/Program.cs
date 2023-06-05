using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string metin = Console.ReadLine();
        Console.WriteLine(metin.Length);



        string[] bosluk;
        bosluk = metin.Split(" ");
        Console.WriteLine(bosluk[0].Length);



        decimal[] dizi = { 1, 4, 7, 543, 42, 64, 42, 312, 59, 699 };
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] += dizi[i] * 10 / 100;
            Console.WriteLine(dizi[i]);
        }

    }
}