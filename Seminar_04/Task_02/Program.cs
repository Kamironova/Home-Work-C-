// Напишите программу, которая принимает на вход число и 
// выдает сумму цифр в этом числе

Console.Clear();

Console.Write("--> ");

int a = Convert.ToInt32(Console.ReadLine());
int s = 0;
while (a > 0)
{ 
    s = s + a % 10;
    a = a / 10 ;
 
}
Console.WriteLine($"Сумма цифр равна {s}");
