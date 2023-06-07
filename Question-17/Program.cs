//        Örnek 17: 10 karakterli rasgele karakterlerden oluşan metin oluşturan örnek:

string charRepo = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";

char[] metin = new char[10];
Random random = new Random();

Console.Write("Rasgele metin: ");
for (int i = 0; i < 10; i++)
{
  int num=random.Next(0,charRepo.Length);

    metin[i] = charRepo[num];
    Console.Write(metin[i]);
}


//foreach (char c in metin)
//{
//    Console.Write(c);
//}
