// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

Console.Clear();

System.Console.Write("Введите количество элементов массива --> ");
int a = Convert.ToInt32(Console.ReadLine());

double[] array = new double[a];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 99);
    System.Console.Write($"[{array[i] + "]"}");
}
System.Console.WriteLine();

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];

    }
    if (array[i] > max)
    {
        max = array[i];
    }
}
System.Console.WriteLine($"Min -> {min}");
System.Console.WriteLine($"Max -> {max}");


System.Console.WriteLine($"Разница -> {max - min}");
