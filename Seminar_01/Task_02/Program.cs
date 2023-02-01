Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (a > b)
{
    if (a > c)
        {
            Console.Write("max = ");
            Console.Write(a);
        }

        
    else
    {
        Console.Write("max = ");
        Console.Write(c);
    }
}
else
{
    if (b > c)
    {
        Console.Write("max = ");
        Console.Write(b);
    }
    else
    {
        Console.Write("max = ");
        Console.Write(c);


    }
}