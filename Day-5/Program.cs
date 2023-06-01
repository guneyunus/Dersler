using System;

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

        HesapMakinesi hesapmakinasi = new HesapMakinesi();
        //hesapmakinasi.Cikar(5,3);

        //CikarmaHandler cikarmaHandler = new CikarmaHandler(hesapmakinasi.Cikar);

        
        //Console.WriteLine(cikarmaHandler(2, 1));

        //Console.WriteLine(cikarmaHandler.Invoke(5, 3));

        Func<int, int> CarpFunc = HesapMakinesi.CarpmaIslemi;
        int b = CarpFunc(5);
        Console.WriteLine(b);




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
