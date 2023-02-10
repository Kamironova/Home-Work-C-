// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние можду ними в 3D пространстве

Console.Clear();

double Coord1()
{
    System.Console.WriteLine("Введите координаты первой точки --> ");
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

double Coord2()
{
    System.Console.WriteLine("Введите координаты второй точки --> ");
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

// System.Console.WriteLine("Введите координаты первой точки --> ");
// double a = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Введите координаты второй точки --> ");
// double b = Convert.ToDouble(Console.ReadLine());

double x1 = Coord1();
double y1 = Coord1();
double z1 = Coord1();

double x2 = Coord2();
double y2 = Coord2();
double z2 = Coord2();

//System.Console.WriteLine(pow(x2 -x1)+ pow(y2 - y1) + pow(z2 - x1));

double x = Math.Pow(x2 - x1);
double y = Math.Pow(y2 - y1);
double z = Math.Pow(z2 - z1);

System.Console.WriteLine(x+y+z);

// вообще х/з как возвести в степень. И пока не понятно нужно ли это