// Напишите цикл, который принимает на вход числа A и B 
// и возводит число A в натуральную степень B.

Console.Clear();

int Pow(int a, int b)
{
    int j = 1;
    int i = 1;
    while (i <= b)
    {
        j = j * a;
        i++;
        
    }
    return j;
}
System.Console.Write("Введите число A --> ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число B --> ");
int b = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine($"{a} в {b} степени = {Pow(a,b)}");


