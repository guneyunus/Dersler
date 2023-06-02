
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Threading.Tasks;
using System;

public class Program
{
    
    public static void Main()
    {

//        Örnek 1: Girilen 3 basamaklı sayının basamaklarına ayıran örnek(Birler, Onlar, Yüzler Basamağındaki sayılar):

//Örnek 2: Girilen bir sayının asal olduğunu bulan ve bu sayıdan sonraki 5 asal sayıyı ekrana yazan program:
//        Örnek 3: Klavyeden girilen bir cümledeki kelime sayısını bulunuz.

//        Örnek 4: Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. Taksi 1 saatten sonraki her saat başı için % 20 daha fazla, minibüs 1 saatten sonraki her saat başı için toplamda % 21.5 ve ticari araç 1 saatten sonraki her saat başı için toplamda % 25 daha fazla ödeme yapmaktadır. Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.

//Örnek 5: Bir komisyoncu sattığı mallardan fiyatı 50 TL kadar olanlardan % 3, daha fazla olanlardan ise % 2 komisyon almaktadır. Klavyeden girilen teker teker girilen 5 malın komisyonlarını bulup ekrana yazdıran ve en sonunda da toplam komisyonu ekrana yazdıran programın kodlarını yazınız.

//Örnek 6:  Kullanıcı tarafından girilen üç sayıdan en büyük ile en küçük sayıyı toplayıp toplam sonucu ekrana yazdıran programı yazınız.

//Örnek 7: Maaşı ve zam oranı girilen işçinin zamlı maaşını hesaplayarak ekranda gösteren C# örneği:

//Örnek 8: Elemanları tam sayı olan bir A dizisinin(20 elemanlı) rastgele sayılar atayan, sonra dizi elemanlarının aritmetik ortalamasını hesaplayan ve elemanlardan kaç tanesinin bu ortalamadan büyük ve küçük olduğunu sayan programın c# kodlarını yazınız.

//Örnek 9: Klavyeden girilen metnin kaç kelimeden oluştuğunu bulan Console Application örneği:

//Örnek 10: Girilen string ifadede “,” karakterlerini “.” karakteri olarak değiştiren örnek:

//Örnek 11:  Girilen String ifadede boşluk karakterine kadar olan kısmı yazdıran örnek:

//Örnek 12 : Elemanları kullanıcı tarafından girilen 10 elemanlı string bir dizide, en uzun metni, en uzun metnin karakter sayısını ve en uzun metnin index numarasını bulan ve ekrana yazdıran Console Örneği:

//        Örnek 13 :  C# Console uygulamasında Elemanları kullanıcı tarafından dışarıdan girilen 10 elemanlı bir dizinin elemanlarını %10 arttıran ve ekrana yazdıran örnek:

//Örnek 14: Verilen bir karakter dizininin substring() metodunu kullanarak string içerisinde arama yapan ve kaç defa geçtiğini bulan program:

//Örnek 15 : Verilen bir string metnin içerisinde harf yada karakterlerin her birinden kaç adet olduğunu bulan program
//        Örnek 16 : Kullanıcının girdiği 3 sayıdan en büyük olanını ekranda gösteren örnek:

//        Örnek 17: 10 karakterli rasgele karakterlerden oluşan metin oluşturan örnek:

//        Örnek 18: 15×15 lik dizi içine rasgele “S” ve “O” harfleri atayan ve ekranda gösteren örnek:

//Örnek 19: İki iç açısı verilen üçgenin diğer açısını bulan örnek:

//        Örnek 20: İçerisinde isimler bulunan string bir diziyi en son elemandan itibaren ekrana yazdıran örnek:

//Örnek 21: Taban değeri ve üssü kullanıcı tarafından girilen işlemin sonucunu For döngüsü kullanarak hesaplayan örnek:

//Örnek 22:  Dik kenar uzunlukları verilen dik üçgende hipotenüs hesaplayan örnek:

//        Örnek 23: C# Console Application ile yapılmış, içerisinde isimler bulunan string bir diziyi en son elemandan itibaren ekrana yazdıran uygulama örneği:

//Örnek 24 : C# Console Uygumasında kullanıcıdan yaş bilgisi istenerek eğer yaşı 18 ve daha büyükse “Ehliyet Alabilirsiniz” yazan,değilse Ehliyet alamazsınız diyerek Ehliyet alabilmesi için kaç yılı kaldığını ekranda gösteren örnek:

//Örnek 25: Kullanıcının girdiği 5 adet sayıyı bir diziye atayarak, bu dizide bulunan çift sayıların ortalamasını ekrana yazan konsol uygulamasını yapınız.

//Örnek 26:  Klavyeden 3 sayıyı girilip bunları ekrana yazdıran program

//Örnek 27: Girilen sayı çift ise yarısını , tek ise 2 katını alarak ekrana yazdıran program.

//Örnek 28 : Klavyeden girilen 3 sayının toplamını ekrana yazdıran program

//Örnek 29: Kullanıcının yapmış olduğu seçime göre girmiş olduğu sayıları toplayan, çıkaran, çarpan yada bölme işlemi yapan program örneği.

//Örnek 30: Klavyeden girilen 3 sayının ortalamasını alan program

//Örnek 31: Klavyeden girilen 2 sayıdan büyük olanını bulan programı yazınız

//Örnek 32: Klavyeden girilen 2 sayıdan büyük olanını bulan büyükten küçüğe altalta yazdıran program

//Örnek 33: Dairenin alanını hesaplayan program

//Örnek 34: C# Console Uygulamasında Kullanıcıdan 2 tane sayı istenerek 1. sayının 2. sayıya tam bölünmesi durumunda “Tam bölünüyor” yazan, aksi durumda Tam bölünmüyor diyerek kalanı ekranda gösteren örnek:

//Örnek 35: Klavyeden girilen bir sayının faktoriyelini alan program

//Örnek 36: Yarıçapı verilen dairenin çevresini hesaplayan örnek:

//Örnek 37: 0′ dan 10′ a kadar olan sayıların toplamını bulan program

//Örnek 38: Klavyeden girilen bir sayıya kadar tek sayıların ve çift sayıların toplamını bulan program

//Örnek 39: Yukarıdaki örnek için sayı 10 olduğunda döngüden çıkan program.

//Örnek 40: a dan z ye kadar olan harfleri ekrana yazdıran program

//Örnek 41: Klavyeden girilen bir sayının tek veya çift olduğunu bulan programı yazınız.

//Örnek 42: 1 den 100 e kadar olan sayılardan 5 e bölünenlerin adedini veren program.

//Örnek 43:  Klavyeden girilen 10 adet sayıdan en büyük ve en küçük olanı bulan program

//Örnek 44: 50 den başlayıp 200 e kadar klavyeden girilen sayıya bölünen kaç adet sayı olduğunu veren program

//Örnek 45: Ortalamaya göre harf notunu bulan program

//Örnek 46: Klavyeden girilen bir sayının seçime bağlı olarak karesini, küpünü ve karekökünü alan programı yazınız.

//Örnek 47: Dizi Örneği

//Örnek 48: Dizi Örneği – 2

//Örnek 49: Dizilere dışardan veri girişi ve veri okunması

//Örnek 50: Rastgele sayılar ile dizi elemanlarını oluşturma

//Örnek 51: Kolonlu Sayısal Loto Sayı Üretme Programı

//Örnek 52: Kullanıcıya kaç tane sayıyı toplayacağını sorup, kullanıcının toplayacağı kadar sayıyı kullanıcıya tek tek soran ve kullanıcının yazdığı bu sayıların toplamını ekrana yazan programı yazınız

//Örnek 53: C# ile klavyeden girilen fiyat değerine % 18 kdv ekleyip kdv’ li fiyatını bulan ve ekrana yazan örnek:

//Örnek 54: Kullanıcı tarafından fiyatı ve KDV oranı girilen ürünün tutarını hesaplayan örnek:

//        Örnek 55: Klavyeden kullanıcı negatif sayı girene kadar girdiği sayıları toplayan C# Console uygulamasına ait örnek:

//Örnek 56: Verilen bir string dizisini, ters sırada(sondan başa doğru) listeleyen örnek:

//Örnek 57: Verilen bir kişi adını bir dizide arayan ve bulunup bulunamadığını belirten C# Console uygulaması örneği:

//Örnek 58:  20 satır 100 sütundan oluşan iki boyutlu sayısal diziye 0 - 100 arasında rastgele sayılardan değer atanacaktır.Değer atandıktan sonra her bir satırdaki elemanların toplamını bulup ekrana yazdıran programı yazınız.

//Örnek 59:  Kendisine değişken sayıda parametre olarak yollanan rakamlardan oluşabilecek en büyük ve en küçük sayıları oluşturup geriye döndüren int BuyukSayi(………) ve int KucukSayi(……) adındaki metotları yazınız

//Örnek 60:  Arka arkaya girilen rastgele 10 tamsayının ortalaması ile bu sayılardan en büyük ve en küçük olanının ortalamasını bularak elde edilen bu iki ortalamanın farkını alan sonuçta tüm sayıların ortalaması, en küçük sayı, en büyük sayı küçük büyük sayıların ortalamasını gösteren C# Console Örneği

//Örnek 61: Kullanıcının girdiği 2 sayı arasındaki çift sayıları yazdıran, ve bu çift sayıların adetini ve toplamını bularak ekranda gösteren C# Console Örneği.

//Örnek 62: Kullanıcının girdiği sayının tam bölenlerini bulan ve ekranda listeleyen, aynı zamanda tam bölenlerin sayısını da ekranda gösteren C# Console Örneği

//Örnek 63: Derece olarak verilen sıcaklığı Fahrenayta çeviren örnek
    }
}
