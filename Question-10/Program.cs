namespace Question_10
{
    //Örnek 10: Girilen string ifadede “,” karakterlerini “.” karakteri olarak değiştiren örnek:

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir string ifade girin: "); //input alma
            string ifade = Console.ReadLine();

            string yeniIfade = ifade.Replace(",", "."); // karakterleri değiştirdiğimiz blok

            Console.WriteLine("Değiştirilmiş ifade: " + yeniIfade); //sonuç ekranı
        }
    }
}