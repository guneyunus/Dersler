namespace Question_14
{
    public class Program
    {
        //Örnek 14: Verilen bir karakter dizininin substring() metodunu kullanarak string içerisinde
        //arama yapan ve kaç defa geçtiğini bulan program:

        static void Main(string[] args)
        {
            string metin = "Bu bir örnek metindir. Örnek metinde örnek kelimesi aranacak.";

            Console.Write("Aranacak alt metini girin: ");
            string aranan = Console.ReadLine();

            int sayac = 0;
            int index = 0;

            while ((index = metin.IndexOf(aranan, index)) != -1) // aranan ifadeyi bulamadığında indexOf -1 döndürür
            {
                sayac++;
                index += aranan.Length;
            }

            Console.WriteLine("Aranan metin '{0}' {1} kez geçiyor.", aranan, sayac);

        }
    }
}