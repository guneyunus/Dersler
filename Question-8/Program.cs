namespace Question_8
{
    //Örnek 8: Elemanları tam sayı olan bir A dizisinin(20 elemanlı) rastgele sayılar atayan,
    //sonra dizi elemanlarının aritmetik ortalamasını hesaplayan ve elemanlardan kaç tanesinin
    //bu ortalamadan büyük ve küçük olduğunu sayan programın c# kodlarını yazınız.
    public class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[20];
            Random random = new Random();

            // Diziyi rastgele sayılarla doldurma
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(1, 251); // 1 ile 250 arasında rastgele bir sayı
            }

            // Dizinin elemanlarını ekrana yazdırma
            Console.Write("Dizi Elemanları: ");
            foreach (int eleman in A)
            {
                Console.Write(eleman + " ");
            }

            // Dizinin aritmetik ortalamasını hesaplama
            int toplam = 0;
            foreach (int eleman in A)
            {
                toplam += eleman;
            }
            double ortalama = (double)toplam / A.Length;

            // Ortalamadan küçük ve büyük elemanların sayısını bulma
            int kucukSayisi = 0;
            int buyukSayisi = 0;
            foreach (int eleman in A)
            {
                if (eleman < ortalama)
                    kucukSayisi++;
                else if (eleman > ortalama)
                    buyukSayisi++;
            }

            // Sonuçları ekrana yazdırma
            Console.WriteLine("\nAritmetik Ortalama: " + ortalama);
            Console.WriteLine("Ortalama'dan Küçük Eleman Sayısı: " + kucukSayisi);
            Console.WriteLine("Ortalama'dan Büyük Eleman Sayısı: " + buyukSayisi);

        }
    }
}