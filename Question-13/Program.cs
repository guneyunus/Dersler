namespace Question_13
{
    public class Program
    {
        //        Örnek 13 :  C# Console uygulamasında Elemanları kullanıcı tarafından dışarıdan girilen 10 elemanlı bir dizinin elemanlarını %10 arttıran ve ekrana yazdıran örnek:

        static void Main(string[] args)
        {
            decimal[] dizi = { 1, 4, 7, 543, 42, 64, 42, 312, 59, 699 };
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] += dizi[i] * 10 / 100;
                Console.WriteLine(dizi[i]);
            }


        }
    }
}