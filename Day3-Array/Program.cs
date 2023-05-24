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