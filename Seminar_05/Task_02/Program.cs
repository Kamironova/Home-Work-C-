// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов стоящих на нечетных позициях.

Console.Clear();

System.Console.Write("Введите количество элементов массива --> ");
int a = Convert.ToInt32(Console.ReadLine());

int[] array = new int[a];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-50, 50);
    System.Console.Write($"[{array[i] +"]"}");
}
System.Console.WriteLine();

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum += array[i];

    }
}

System.Console.WriteLine(sum);