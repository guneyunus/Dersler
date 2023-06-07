//        Örnek 20: İçerisinde isimler bulunan string bir diziyi en son elemandan itibaren ekrana yazdıran örnek:

string[] names = new string[] { "semih", "göker", "deniz", "mustafa", "burak","yunus" };


for (int i = names.Length-1; i >= 0 ; i--)
{
    Console.WriteLine($"{i+1}. eleman: "+names[i]);
}