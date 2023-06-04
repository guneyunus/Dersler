namespace Question_5
{
    //Örnek 5: Bir komisyoncu sattığı mallardan fiyatı 50 TL kadar olanlardan % 3, daha fazla olanlardan ise % 2 komisyon almaktadır.
    //Klavyeden girilen teker teker girilen 5 malın komisyonlarını bulup ekrana yazdıran ve en sonunda da toplam komisyonu ekrana yazdıran programın kodlarını yazınız.

    public class Program
    {
        static double KomisyonHesapla(double fiyat)
        {


            if (fiyat <= 50)
            {
                return fiyat * (0.03);
            }
            else
            {
                return fiyat * (0.02);
            }

        }
        static void Main(string[] args)
        {

            List<double> totalKomisyon =new();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Fiyat Giriniz:");
                int input = Convert.ToInt32(Console.ReadLine());
                totalKomisyon.Add(KomisyonHesapla(input));

                Console.WriteLine($"Ürünün Komisyonu:{KomisyonHesapla(input)} ");
            }
            Console.WriteLine("Toplam Komisyon : "+totalKomisyon.Sum());
        }
    }
}