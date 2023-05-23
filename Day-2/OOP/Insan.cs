using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2.OOP
{
    public class Insan
    {
        //fields
        public string ad;

        //properties
        public string Isim { get; set; }
        public DateTime Yas { get; set; }
        public bool Cinsiyet { get; set; }

        //constructor -- yapıcı metod
        public Insan()
        {

        }
        //Aşırı yükleme -- overload
        public Insan(string DegiskendenGelenIsım)
        {
            ad = DegiskendenGelenIsım;
            Isim = DegiskendenGelenIsım;
        }
        public Insan(string str, DateTime time)
        {
            Isim = str;
            Yas = time;
        }
        public Insan(string str, DateTime time, bool cins)
        {
            Isim = str;
            Yas = time;
            Cinsiyet = cins;
        }
        public string NefesAl()
        {
            return "Nefes aldım";
        }

    }
    public class Fultbolcu : Insan
    {
        public List<string> OynadigiTakimlar;
        public virtual string SutCek()
        {
            return "10 puanlık şet çeker.";
        }
    }
    //public class Taksici : Insan // Kalıtım aldıgını izah ediyor.
    //{

    //}
    //public class Yuzucu : Insan
    //{

    //}

    public class DefansOyuncusu : Fultbolcu
    {
        public override string SutCek()
        {
            return "5 puanlık şut çekerim";
        }
    }
    public class HucumOyuncusu : Fultbolcu
    {
        public override string SutCek()
        {
            return base.SutCek();
        }
    }

    public class BaseTranslate
    {
        public string HttpReq { get; set; }
        public virtual string Translate(string gelenMetin,int dilKodu)
        {
            return $"{HttpReq} Cevrilien Cumle";
        }
    }

    public class GoogleTranslat : BaseTranslate
    {
       
        public GoogleTranslat(string url)
        {
            this.HttpReq = url;
            
        }
        public override string Translate(string gelenMetin, int dilKodu)
        {
            return base.Translate(gelenMetin, dilKodu);
        }
        public string Translate()
        {
            return "Url'ye ulasamadım.";
        }
    }
    //polimorfizm
    public class BingTanslate : BaseTranslate
    {
        public string ErrorHandler { get; set; }
        public BingTanslate(string errorHandler,string param)
        {
            ErrorHandler = errorHandler;
            this.HttpReq= param;
        }
        public override string Translate(string gelenMetin, int dilKodu)
        {
            return $"{ErrorHandler+ gelenMetin+dilKodu}";
        }
    }
}
