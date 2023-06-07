//        Örnek 16 : Kullanıcının girdiği 3 sayıdan en büyük olanını ekranda gösteren örnek:

Console.WriteLine("3 adet sayı giriniz.");
int maxNum = 0;

for (int i = 0; i < 3; i++)
{
    Console.Write($"{i + 1}. sayı:");
    int input = Convert.ToInt32(Console.ReadLine());

    if (input > maxNum)
    {
        maxNum = input;
    }
}

Console.WriteLine($"En büyük sayı: {maxNum}");
