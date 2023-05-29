int toplam(int[] dizi)
{
    int sonuc = 0;
    for (int i = 0; i < dizi.Length; i++)
    {
        sonuc += dizi[i];
    }

    return sonuc;
}

decimal ortalama(int[] dizi)
{
    decimal sonuc = 0;
    for (int i = 0; i < dizi.Length; i++)
    {
        sonuc += dizi[i];
    }

    decimal ort = sonuc / dizi.Length;

    return ort;
}

int max(int[] dizi)
{
    int buyuk = dizi[0];
    for (int i = 0; i < dizi.Length; i++)
    {
        if (buyuk < dizi[i])
            buyuk = dizi[i];
    }

    return buyuk;
}

int min(int[] dizi)
{
    int kucuk = dizi[0];
    for (int i = 0; i < dizi.Length; i++)
    {
        if (kucuk > dizi[i])
            kucuk = dizi[i];
    }

    return kucuk;
}

int[] sort(int[] dizi)
{
    int a;

    for (int i = 0; i < dizi.Length; i++)
    {
        for (int j = i; j < dizi.Length; j++)
        {
            if (dizi[i] > dizi[j])
            {
                a = dizi[j];
                dizi[j] = dizi[i];
                dizi[i] = a;
            }
        }
    }

    return dizi;
}

int[] sortF(int[] dizi)
{
    int[] temp = dizi;
    int sayac = 0;
    foreach (int i in dizi)
    {
        foreach (int j in dizi)
        {
            if (i > j)
                temp[sayac] = i;
        }
        sayac++;
    }
    return dizi;
}


int[] myArray = { 1, 5, 2, 7, 4 };

//MAX
Console.WriteLine("MAX = " + max(myArray));
//MİN
Console.WriteLine("MİN = " + min(myArray));
//ORT
Console.WriteLine("ORT = " + ortalama(myArray));
//TOPLAM
Console.WriteLine("TOPLAM = " + toplam(myArray));

//SORT
Console.WriteLine("SORTED ARRAY : ");

foreach (int i in sort(myArray))
{
    Console.WriteLine(i);
}


//SORT
Console.WriteLine("SORTED ARRAY foreach : ");

foreach (int i in sortF(myArray))
{
    Console.WriteLine(i);
}



//EKSİK SAYI
int missing = 0;
int[] array = { 1, 2, 3, 4, 5, 6, 7, 9, 10 };
for (int i = 1; i <= array.Length; i++)
{
    if (i != array[i - 1])
    {
        missing = i;
        break;
    }
}
Console.WriteLine(missing);

//BYTE TO STRİNG
byte[] bytes = { 14, 2, 5, 32, 25 };
string metin = Convert.ToBase64String(bytes);
Console.WriteLine(metin);


//ELEMAN BAŞLANGIÇ-BİTİŞ
int[] arraym = { 1, 2, 5, 8, 12, 16, 29 };
int sayi = 5;
int baslangic = Array.IndexOf(arraym, sayi);
int bitis = arraym.Length - 1 - baslangic;
Console.WriteLine(baslangic + " - " + bitis);

//TEKRARLI ELEMAN
int[] arrayt = { 1, 20, 15, 81, 12, 160, 29, 12, 81, 20 };
List<int> tekrarli = new List<int>();
int sayac = 0;
foreach (int item in arrayt)
{
    foreach (int item2 in arrayt)
    {
        if (item == item2)
        {
            sayac++;
        }
        if (sayac > 1 && !tekrarli.Contains(item))
        {
            tekrarli.Add(item);
            break;
        }

    }
    sayac = 0;
}

foreach (int item in tekrarli)
    Console.WriteLine(item);


//ÖTELEME
int[] arrayo = { 1, 20, 15, 81, 12, 160, 29, 12, 81, 20 };
int k = 5;
int[] temp = new int[10];
arrayo.CopyTo(temp, 0);
int sayaco = 0;

for (int i = k; i < arrayo.Length; i++)
{
    temp[sayaco] = arrayo[i];
    sayaco++;
}

for (int i = 0; i < k; i++)
{
    temp[sayaco] = arrayo[i];
    sayaco++;
}

foreach (int i in temp)
    Console.WriteLine(i);


//MEDYAN
int[] array1 = { 1, 2, 6, 8, 12, 5, 75, 26 };
int[] array2 = { 10, 20, 60, 80, 120, 50, 260, 750 };
int[] arrays = array1.Union(array2).ToArray();

int a;

for (int i = 0; i < arrays.Length; i++)
{
    for (int j = i; j < arrays.Length; j++)
    {
        if (arrays[i] > arrays[j])
        {
            a = arrays[j];
            arrays[j] = arrays[i];
            arrays[i] = a;
        }
    }
}

if (arrays.Length % 2 == 0)
{
    int sol = arrays[((arrays.Length - 1) / 2)];
    int sag = arrays[((arrays.Length + 1) / 2)];
    Console.WriteLine((sol + sag) / 2);
}
else if (arrays.Length % 2 != 0 && arrays.Length > 1)
{
    int orta = arrays[((arrays.Length - 1) / 2)];
    Console.WriteLine(orta);
}
else
{
    int orta = arrays.First();
    Console.WriteLine(orta);
}


//ARDIŞIK ELEMAN UZUNLUĞU
int[] arraya = { 1, 2, 3, 6, 8, 12, 5, 75, 26 };

int maxCount = 1;
int count = 1;
bool degisti = false;

for (int i = 0; i < arraya.Length - 1; i++)
{
    if (arraya[i] < arraya[i + 1] && !degisti)
    {
        count++;
    }
    else if (arraya[i] > arraya[i + 1] && count > 0)
    {
        degisti = true;
        count = 2;
    }
    else if (arraya[i] > arraya[i + 1] && count == 0)
    {
        count++;
    }

    if (count > maxCount)
    {
        maxCount = count;
    }
}
Console.WriteLine(maxCount);


//ALT DİZİ
int[] arrayad = { 1, -2, 3, -6, -8, -12, -5, 75, -26 };

int maxCountad = arrayad.Max();
int countad = 0;
bool var = false;


for (int i = 0; i < arrayad.Length; i++)
{
    if (arrayad[i] > 0)
    {
        countad += arrayad[i];
        var = true;
    }


    if (countad > maxCountad && var)
        maxCountad = countad;

}
Console.WriteLine(maxCountad);