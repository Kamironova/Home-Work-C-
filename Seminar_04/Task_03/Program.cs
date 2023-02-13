// Объявить массив из 8 элементов и заполнить его случайным значениями

Console.Clear();

int[] array = new int[8];

Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(10);
}

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"[{array[i] + "]"}");
}
System.Console.WriteLine();