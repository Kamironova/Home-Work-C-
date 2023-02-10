Console.Clear();

System.Console.Write("-->");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= n; i++)
{
    System.Console.Write($" {i * i * i} "); // подумать над красивым форматированием
}
System.Console.WriteLine();