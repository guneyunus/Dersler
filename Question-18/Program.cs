//        Örnek 18: 15×15 lik dizi içine rasgele “S” ve “O” harfleri atayan ve ekranda gösteren örnek:

using System;

string charRepo = "SO";

char[,] array = new char[15, 15];

Random random = new Random();

for (int i = 0; i < 15; i++)
{    
    for (int j = 0; j < 15; j++)
	{
        int num = random.Next(0, charRepo.Length);

        array[i,j] = charRepo[num];
        Console.WriteLine($"Array[{i},{j}]="+array[i,j]);
    }
}