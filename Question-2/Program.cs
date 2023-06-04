//Örnek 2: Girilen bir sayının asal olduğunu bulan ve bu sayıdan sonraki 5 asal sayıyı ekrana yazan program:

using System.Diagnostics.Metrics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static bool AsalMi(int sayi)
    {
        if (sayi < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
                return false;
        }

        return true;
    }

    public static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int input = Convert.ToInt32(Console.ReadLine());


        int asalSayac = 0;
        int sayac = input + 1;
        if (AsalMi(input))
        {
            Console.WriteLine($"{input} sayısı asal.");
            Console.WriteLine("Sonraki 5 asal sayı:");

        }

        while (asalSayac < 5)
        {

            if (AsalMi(sayac))
            {

                Console.WriteLine(sayac);
                asalSayac++;
            }
            sayac++;

        }
        Console.ReadLine();

    }
}

