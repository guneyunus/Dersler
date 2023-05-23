// See https://aka.ms/new-console-template for more information


using Day_2.OOP;

//Fultbolcu CenkTosun = new Fultbolcu();
//CenkTosun.Cinsiyet = true;
//CenkTosun.Isim = "Cenk Tosun";
//CenkTosun.Yas = new DateTime(1975,10,12);

//Fultbolcu Ronaldo = new Fultbolcu();

//Random rnd = new Random();
//int randomSayi = rnd.Next(100,500);

////ternary if
//BaseTranslate translate = 9 % 2 == 0 ? new GoogleTranslat("Deneme") : new BingTanslate("Eroor","param");
//string aa =translate.Translate("deneme",10);

//Auid audi = new Auid(new DateTime(2010, 10, 10));
//Console.WriteLine(audi.Durum());
//Console.WriteLine(audi._id);
//audi.CalKorna(25);
//Console.WriteLine(audi._id);
//Console.WriteLine(audi.Name());

//Bmw bmw = new Bmw(new DateTime(2021,12,12));
//Console.WriteLine(bmw.Durum());
//Console.WriteLine(bmw._degisimAdedi);
//bmw.CalKorna(25);
//Console.WriteLine(bmw._degisimAdedi);
//Console.WriteLine(bmw.Name());

//Array 
int[] firstArray;

firstArray = new int[5] { 13, 23, 5, 67, 19 };
string[] secondArray = new string[3] {"Göker","Deniz","Ys"};
//indis sıralaması 0'dan başlar
firstArray[0] = 4;
secondArray[2] = "Deneme";

var thirtArray = new int[] { 100, 99, 98 };

int arrayUzunlugu = firstArray.Length;
firstArray.Max();/// arayin en büyük değerini döndürür
firstArray.Min();/// arayin en üçük değerini döndürür
firstArray.Sum();/// arayin toplam değerini döndürür
firstArray.Average();/// arayin ortalamasını döndürür

secondArray.Max();
secondArray.Min();

Array.Sort(firstArray); //sıralama func. 
Array.Reverse(firstArray); // büyükten küçüğe sıralama (desc)
Array.ForEach(firstArray , x =>
{
    Console.WriteLine(x);
});
//Lamda expression ile foreach yazımında return veremeyiz.!!


Console.ReadLine();