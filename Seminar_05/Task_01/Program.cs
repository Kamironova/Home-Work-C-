// Задайте массив заполенный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.

Console.Clear();

int[] array = new int[6];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100, 999);
}

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"[{array[i] +"]"}");
}
System.Console.WriteLine();

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count ++;
    }
    
}

System.Console.WriteLine(count);
