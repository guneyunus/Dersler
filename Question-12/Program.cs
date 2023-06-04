namespace Question_12
{
    // Örnek 12 : Elemanları kullanıcı tarafından girilen 10 elemanlı string bir dizide,
    // en uzun metni, en uzun metnin karakter sayısını ve en uzun metnin index numarasını bulan
    // ve ekrana yazdıran Console Örneği:

    public class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = new string[10];

            // Kullanıcıdan elemanları alınan dizi oluşturuluyor
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Dizinin {0}. elemanını girin: ", i);
                dizi[i] = Console.ReadLine();
            }

            // En uzun metni bulmak için dizi taranıyor
            int enUzunIndex = 0;
            int enUzunKarakterSayisi = 0;

            for (int i = 0; i < 10; i++)
            {
                if (dizi[i].Length > enUzunKarakterSayisi)
                {
                    enUzunKarakterSayisi = dizi[i].Length;
                    enUzunIndex = i;
                }
            }

            // Sonuçlar ekrana yazdırılıyor
            Console.WriteLine("En uzun metin: " + dizi[enUzunIndex]);
            Console.WriteLine("En uzun metnin karakter sayısı: " + enUzunKarakterSayisi);
            Console.WriteLine("En uzun metnin index numarası: " + enUzunIndex);

        }
    }
}