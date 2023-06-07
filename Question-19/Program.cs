//Örnek 19: İki iç açısı verilen üçgenin diğer açısını bulan örnek:

static int thirdAngleCal(int firstAngle, int secondAngle)
{
    return 180-(firstAngle+secondAngle);
}
Console.Write("Lütfen ilk açıyı giriniz: ");
int firstAngle = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen ikinci açıyı giriniz: ");
int secondAngle = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Üçüncü Açı: "+ thirdAngleCal(firstAngle, secondAngle));