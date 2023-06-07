//Örnek 15 : Verilen bir string metnin içerisinde harf yada karakterlerin her birinden kaç adet olduğunu bulan program

string metin = "Soruuu 15 çözümüüüu.?";

//Dictionary<TKey, TValue>, anahtar/değer çiftlerini belirli bir sırada depolayan genel bir koleksiyondur.
Dictionary<char, int> karakterSayilari = new Dictionary<char, int>();

foreach (char karakter in metin)
{
    if (char.IsLetterOrDigit(karakter)|| char.IsPunctuation(karakter)) //Sadece harf veya rakam karakterlerini saymak için ve noktalama işaretleri için Punctuation
    {
        if (karakterSayilari.ContainsKey(karakter))  // Dictionary update
        {
            karakterSayilari[karakter]++;
        }
        else
        {
            karakterSayilari[karakter] = 1;
        }
    }
}

foreach (KeyValuePair<char, int> karakter in karakterSayilari)
{
    Console.WriteLine("'{0}' karakterinden {1} adet bulundu", karakter.Key, karakter.Value);

   // Console.WriteLine($"'{karakter.Key}' karakterinden {karakter.Value} adet bulundu");

}

//dizini kullanarak anahtar-değer çiftini almak için ElementAt() kullanın
for (int i = 0; i < karakterSayilari.Count; i++)
{
    Console.WriteLine("Key: {0}, Value: {1}", karakterSayilari.ElementAt(i).Key, karakterSayilari.ElementAt(i).Value);
}