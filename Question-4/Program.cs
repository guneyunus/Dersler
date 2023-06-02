//Örnek 4: Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 7 TL dir. Taksi 1 saatten sonraki her saat başı için % 20 daha fazla, minibüs 1 saatten sonraki her saat başı için toplamda % 21.5 ve ticari araç 1 saatten sonraki her saat başı için toplamda % 25 daha fazla ödeme yapmaktadır. Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.

// 1. Adım ; Taksi, minibüs ve ticari araç için string tanımlanır. ( aracın tipi )
// 2. Adım ; park süresi için Int tanımlanır.
// 3. Adım ; ödenecek tutar için int tanımlanır.

public class Program
{
    static void Main()
    {
        //string[] aracTipi = ["taksi", "minibüs", "ticari"];

        int aracTipi = 1;

        // taksi = 1
        // minibüs = 2 
        // ticari =3 

        int parkSuresi = 2;

        double odenecekTutar = 0;

        if (parkSuresi > 1)
        {
           for(int i = 1; i<= parkSuresi; i++)
            {
                if(i == 1)
                {
                    if(aracTipi== 1)
                    {
                        odenecekTutar = i * 5;
                    }
                    else if(aracTipi== 2)
                    {
                        odenecekTutar = i * 6;
                    }
                    else
                    {
                        odenecekTutar = i * 7;
                    }
                }
                else
                {
                    parkSuresi -= 1;

                    if (aracTipi == 1)
                    {
                        odenecekTutar += parkSuresi * 5 * 1.20;
                    }
                    else if (aracTipi == 2)
                    {
                        odenecekTutar += parkSuresi * 6 * 1.215;
                    }
                    else
                    {
                        odenecekTutar += parkSuresi * 7 * 1.25;
                    }

                }
            }
        }
        else 
        {
            if (aracTipi == 1)
            {
                odenecekTutar = parkSuresi * 5;

            }
            else if (aracTipi == 2)
            {
                odenecekTutar = parkSuresi * 6;
            }
            else
            {
                odenecekTutar = parkSuresi * 7;
            }
        }
        Console.WriteLine(odenecekTutar);


    }



}