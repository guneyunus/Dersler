﻿using System;
using System.Linq;

public class Program
{
    public class HesapMakinesi
    {
        public int Cikar(int a, int b)
        {
            return a - b;
        }

        public static int CarpmaIslemi(int a)
        {
            return a * (a-1);
        }


    }
    public static void Main()
    {
        //Console.WriteLine("Hello World");
        //int a = 1;
        //string b  = "hello";
        //Deneme abc = new Deneme();
        //var denemeObjecsi = abc.GetNewDeneme(a,b);
        ////denemeObjecsi.setYasIkı();
        ///

        //HesapMakinesi hesapmakinasi = new HesapMakinesi();
        //hesapmakinasi.Cikar(5,3);

        //CikarmaHandler cikarmaHandler = new CikarmaHandler(hesapmakinasi.Cikar);


        //Console.WriteLine(cikarmaHandler(2, 1));

        //Console.WriteLine(cikarmaHandler.Invoke(5, 3));

        //public static int CarpmaIslemi(int a)
        //{
        //    return a * (a - 1);
        //}

        //Fuc<T,TRESULT>
        Func<int, int> CarpFunc = HesapMakinesi.CarpmaIslemi;
        int b = CarpFunc(5);
        Console.WriteLine(b);


        int bankCode = 1000;

        Func<bool> bankaVarMı = () =>
        {
            if (bankCode == 1000)
            {
                return true;
            }
            else if(bankCode == 1100)
            {
                return true;
            }
            else
            {
                return false;
            }

        };

        bool varlikDurumu = bankaVarMı();

        if (bankaVarMı())
        {
            Console.WriteLine();
        }

        List<int> sayilar = new List<int> { 1, 2, 3,4,5,6,7,8,9,10 };

        List<int> IkiyeBolunenler = sayilar.Where(q => q % 2 == 0 ).Where(x => x - 1 > 0).ToList();
        List<int> IkiyeBolunenler2 = sayilar.Where(q => q % 2 == 0 && q - 1 > 0 ).ToList();

        List<string> Alfabe = new List<string>() { "A","B","C","D","E","F"};

        List<string> Sesliler = Alfabe.Where(q => q.Any()).ToList();

        var sesliler = Alfabe.Where(q => q.Contains('e')).ToArray();




        List<string> Listem = new List<string> { "Gökker", "Denniz", "Semihhh", "Yunussz" };

        foreach (var item in Listem)
        {
            item.ToLower().GroupBy(x => x).ToList().ForEach(a =>
            {
                if (a.Count() > 1)
                    Console.WriteLine(a.Key + " : " + a.Count());
            });


        }

        Console.WriteLine("");

        List<int> piyangod = new List<int>();
        List<int> piyangog = new List<int>();
        List<int> piyangos = new List<int>();

        Random Random = new Random();

        for (int i = 0; i < 10; i++)
        {
            piyangod.Add(Random.Next(1, 10));
            piyangos.Add(Random.Next(1, 10));
            piyangog.Add(Random.Next(1, 10));
        }

        piyangod.ForEach(a =>
        {
            Console.Write(a);
        });
        Console.WriteLine("");
        piyangos.ForEach(a =>
        {
            Console.Write(a);
        });
        Console.WriteLine("");
        piyangog.ForEach(a =>
        {
            Console.Write(a);
        });
        Console.WriteLine("");
        //1 - en çok tekrar eden

        piyangod.AddRange(piyangog);
        piyangod.AddRange(piyangos);


        Console.WriteLine(piyangod.GroupBy(x => x).ToList().OrderByDescending(a => a.Count()).First().Key);
        piyangod.GroupBy(x => x).ToList().OrderByDescending(a => a.Count()).Select(z => z.Key).Take(5).ToList().ForEach(a =>
        {
            Console.WriteLine(a);
        });

        //2 - en çok tekrar eden 5 sayı toplamı

        Console.WriteLine(piyangod.GroupBy(x => x).ToList().OrderByDescending(a => a.Count()).Select(z => z.Key).Take(5).Sum());

    }
}



// DELEGATE NEDİR ? EVENT NEDİR ? LAMDA EXPRESSİON NEDİR ? 

// HANGİ SCOPE'ta çalışabilir => acces modifier public ,internal prvate ....
// DELEGATE => delege olduğunu belirten keyword
// GERİYE NE DÖNDÜRECEK ? void , int, bool , string ,object 
// İsimlendirme 
// HANDLER
//

public delegate void ToplamaHandler();


public delegate string IcerideBUlHandler(string aranan,char aranilacak);

public delegate int CikarmaHandler(int cikarilan, int cikan);



//ACCES MODİFİER

//ERiŞİM BELRİLEYİCİ

// PUBLİC İNTERNAL PRİVATE => encapsulation


public class Deneme
{
    public int Yas { get; private set; }
    public string Name { get; private set; }

    public Deneme()
    {
    }
    private Deneme(int a, string b)
    {

        Name = b;
        setYasIkı();
    }
    public void setyas(int c)
    {
        Yas = c;
    }

    public Deneme GetNewDeneme(int a, string c)
    {
        return new Deneme(a, c);
    }

    private void setYasIkı()
    {
        Yas = 1;
    }


}

// FUNC YAPILANMASI ÖNCEDEN TANIMLANMIŞ DELEGATE 




