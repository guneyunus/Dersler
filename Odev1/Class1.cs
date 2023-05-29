using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public class Class3
    {

        //Bir bayt dizisini String'e nasıl dönüştürebilirim?
        public static void Main()
        {
            byte[] bytes = Convert.FromBase64String("QUJDMTIz");
            Console.WriteLine("Byte Array is: " + String.Join(" ", bytes));

            string str = Convert.ToBase64String(bytes);
            Console.WriteLine("The String is: " + str);
        }

        

    }

    public class Class4
    {
        //Belirli bir dizide ikili aramayı nasıl gerçekleştirirsiniz? (binary search)
        static void Main(string[] args)
        {
            // Create an array of 10 elements    
            int[] IntArray = new int[10] { 1, 3, 5, 7, 11, 13, 17, 19, 23, 31 };
            // Value to search for    
            int target = 17;
            int pos = Array.BinarySearch(IntArray, target);
            if (pos >= 0)
                Console.WriteLine($"Item {IntArray[pos].ToString()} found at position {pos + 1}.");
            else
                Console.WriteLine("Item not found");
            Console.ReadKey();
        }
    }

    internal class Class5
    {
        private static void Main(string[] args)
        {
           // İki tür dizinin medyanı nasıl bulunur? 

            int[] sayiDizisi = new[] { 1, 5, 2, 8, 3 };

            int dizininUzunlugu = sayiDizisi.Length;
            
            Array.Sort(sayiDizisi);

            if ((dizininUzunlugu % 2 == 1))
            {
                int tekliSira = (dizininUzunlugu + 1) / 2;
                Console.WriteLine(sayiDizisi[tekliSira - 1]);
            }
         
            else
            {
                double ikiliSira = dizininUzunlugu / 2.0;
                double ortaSayi = (sayiDizisi[(int)ikiliSira - 1] + sayiDizisi[(int)ikiliSira]) / 2.0;
                Console.WriteLine(ortaSayi);
            }

            Console.Read();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numaralar = { 1,2,3,4,5,6,7,8,9,10 };

            int[] tamNumaralar = new int[numaralar.Length + 1];

            for (int i = 0; i < numaralar.Length + 1; i++)
                tamNumaralar[i] = i + 1;

            IEnumerable<int> eksikSayi = tamNumaralar.Except(numaralar);

            foreach (int sayi in eksikSayi)
                Console.WriteLine(sayi);

            Console.Read();
        }
    }
}
