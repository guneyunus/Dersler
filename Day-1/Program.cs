// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");


string a = "Deneme Yazısı";

string b = "Gökerin gökkuşağı gibi gözleri var maşallah";

decimal format = Convert.ToDecimal(a,CultureInfo.GetCultureInfo(1));



string c = a + b;

a += "Yunusun göbeği";

c += " 15";

Console.ReadLine();