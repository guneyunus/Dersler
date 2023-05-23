// See https://aka.ms/new-console-template for more information


using Day_2.OOP;

//Fultbolcu CenkTosun = new Fultbolcu();
//CenkTosun.Cinsiyet = true;
//CenkTosun.Isim = "Cenk Tosun";
//CenkTosun.Yas = new DateTime(1975,10,12);

//Fultbolcu Ronaldo = new Fultbolcu();

Random rnd = new Random();
int randomSayi = rnd.Next(100,500);

//ternary if
BaseTranslate translate = 9 % 2 == 0 ? new GoogleTranslat("Deneme") : new BingTanslate("Eroor","param");
string aa =translate.Translate("deneme",10);

Console.ReadLine();