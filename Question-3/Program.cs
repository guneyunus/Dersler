// Örnek 3: Klavyeden girilen bir cümledeki kelime sayısını bulunuz. ( klavyeden girilen string ifade bulunacak )

string cumle = "lorem ipsum dolor sit amet consectetur adipiscing elit";
Console.WriteLine(cumle);

string[] kelimeler = cumle.Split(' ');
Console.WriteLine(kelimeler.Length);
Console.WriteLine(kelimeler[0]);