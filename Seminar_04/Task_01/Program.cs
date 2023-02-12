// Напишите цикл, который принимает на вход числа A и B 
// и возводит число A в натуральную степень B.

Console.Clear();

System.Console.Write("Введите число A --> ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("введите число B --> ");
int b = Convert.ToInt32(Console.ReadLine());

int j = 1;
int i = 1;
while (i <= b)
{
    j = j * a;
    i++;
}

System.Console.WriteLine(j);

//${a}", "{b}" --> {j}"