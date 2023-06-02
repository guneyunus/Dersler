//        Örnek 1: Girilen 3 basamaklı sayının basamaklarına ayıran örnek(Birler, Onlar, Yüzler Basamağındaki sayılar):

int değerler tanımlanır. örn; 123


int sayi = 123;

int yuzlerBasamagı = sayi / 100;

Console.WriteLine(yuzlerBasamagı);

int onlarBasamagı = (sayi - yuzlerBasamagı * 100) / 10;

Console.WriteLine(onlarBasamagı);

int birlerBasamagı = sayi - (yuzlerBasamagı * 100) - (onlarBasamagı * 10);

Console.WriteLine(birlerBasamagı);

