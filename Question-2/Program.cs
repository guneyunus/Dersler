//Örnek 2: Girilen bir sayının asal olduğunu bulan ve bu sayıdan sonraki 5 asal sayıyı ekrana yazan program:

public class Program
{

    public static void Main()
    {

        int input = Convert.ToInt32(Console.ReadLine());

        int asal = input;
        int counter = 0;

        for (int i = 2; i < input; i++)
        {
            if (asal % i == 0)
            { counter++; }
        }

        if (counter != 0)
        {
            Console.WriteLine("Sayı Asal Değildir.");
        }
        else
        {
            Console.WriteLine("Sayı Asaldır.");
            int sayac = 0;
            do
            {
                Console.WriteLine(input);
                input++;

                for (int i = 2; i < input; i++)
                {
                    if (asal % i == 0)
                    { counter++; }
                }

                if (counter == 0)
                {
                    sayac++;
                    Console.WriteLine(input);
                }

            } while (sayac == 5);



        }
        Console.ReadKey();
    }
}