﻿// See https://aka.ms/new-console-template for more information

namespace Odev1
{
    public class Class1
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

    public class Program
    {
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
}

