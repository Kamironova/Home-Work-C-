Console.Clear();


System.Console.Write("Введите число --> ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 99)
{
    System.Console.WriteLine("Третьей цифры нет");
    
}
else
{
    while (a > 999)
    {
        a = a / 10;
    }

    int b = a % 10;
    System.Console.WriteLine(b);
}

