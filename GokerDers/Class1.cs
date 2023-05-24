using System;

namespace Dersler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max(int[] array)

            {
                int toplama = 0;

                foreach (int toplam in array)
                {
                    toplama += toplam;
                    Console.WriteLine(toplam);

                }
                return toplama;


            }

            int toplama = max(new int[3] { 1, 2, 3 });

            Console.WriteLine(toplama);


            int ortalama(int[] array)
            {
                int item = 0;

                foreach (int ortala in array)
                {
                    item = item + ortala;
                    Console.WriteLine(item);

                }
                return item / array.Length;
            }
            int item = ortalama(new int[5] { 1, 2, 3, 4, 5 });

            Console.WriteLine(item);

            int maximum(int[] dizi)
            {
                int max = 0;
                int[] array = dizi;

                foreach (int maximum in dizi)
                {
                    foreach (int maximum2 in array)
                    {
                        if (maximum > maximum2 && max < maximum)
                        {
                            max = maximum;

                        }
                    }


                }
                return max;
            }
            Console.WriteLine(maximum(new int[5] { 1, 2, 7, 9, 5 }));


        }
    }






}
