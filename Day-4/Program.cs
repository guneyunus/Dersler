
// IList neden önemli , IEnumerable nedir?

// ArrayList 

using System.Collections;
using System;
					
public class Program
{
    public static void Main()
    {

        //public class denemetor
        //{
        //    public int adı { get; set; }
        //    public int soyadı { get; set; }
        //    public int tc { get; set; }
        //}

        //liste1.Add(new denemetor());

        ArrayList liste1 = new ArrayList();
        //Arraylistlerde tip durumuna bakılmaksızın objct'ler ile işlem yaılabilir

        liste1.Add(10);
        liste1.Add("yunus");
        liste1.Add(false);
        liste1.Add(null);


        string[] stringArrayi = { "Göker", "Deniz", "Semih", "Yunus" };

        liste1.AddRange(stringArrayi);

        int kapasitesi = liste1.Capacity;

        liste1.Clear();

        liste1.RemoveAt(0);

        liste1.RemoveRange(0, 5);

        liste1.Clone();

        bool varMi = liste1.Contains("Göker");
        bool varMi2 = !liste1.Contains("Yunus");

        int indexi = liste1.IndexOf("Deniz");

        // ***** Yunus ****** A111111 ******* @@@@

        //ORM OBJECT RELATİONAL MAPPİNG

        /// Adı ------- Soyadı ------ tc -------- boy ----- kilo
        /// yunus ------- guney ------ 123 -------- 123 ----- 123
        /// Adı ------- Soyadı ------ tc -------- boy ----- kilo
        /// Adı ------- Soyadı ------ tc -------- boy ----- kilo
        /// Adı ------- Soyadı ------ tc -------- boy ----- kilo
        /// Adı ------- Soyadı ------ tc -------- boy ----- kilo
        /// Adı ------- Soyadı ------ tc -------- boy ----- kilo
        /// 


        //Ternary if kullanımı

        liste1.Add($@"Deneme {(liste1.Contains("Göker") == true ? "Deniz" : "Yunus")} değeri");



        // List

        List<string> liste2 = new List<string>();

        //arrow function || lamda expression

        liste2.ForEach(item =>
        {
            if (true)
            {
                liste1.Add(item);
            }
        });


        //belirsiz fonksiyon
        liste2.Any(q => liste1.Contains(q));
        liste2.Any();

        // IQueryable Nedir ? 


        //List nesneleri LİNQ İle sorgu haline getirilebilir ve bu yordamlarla işlem yaptırılılabilir.
        //IQueryable çalıştığı zaman sorgu oluşmaz.Çalıştırmaya hazır hale getirilir.

        List<Telefon> telefonlar = new List<Telefon>();
        telefonlar.Add(new Telefon { Model = 1970, Name = "Motorola" });
        telefonlar.Add(new Telefon { Model = 1980, Name = "Şahin" });
        telefonlar.Add(new Telefon { Model = 1990, Name = "YunoCell" });

        //select * from Product

        var linqExample = from tlfn in telefonlar
                          where tlfn.Name.Contains("Yuno") 
                          select tlfn;

        var linqExample2 = telefonlar.Where(x => x.Name.Contains("Yuno")).AsQueryable();


        //IEnumerable nesneler listesini , verilen şartlara bağlı olarak oluşturup GERÇEK OBJE DEĞERLERİNİ DÖNDÜRÜR.
        var linqDevamı = linqExample2.Where(q => q.Model == 1970).ToList();

    }
}

public class Telefon
{
    public string Name { get; set; }
    public int Model { get; set; }

}