Console.Clear();

System.Console.Write("Введите трехзначное число --> ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 10;
int c = a % 100 / 10;


System.Console.WriteLine(c);