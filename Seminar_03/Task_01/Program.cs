// Напишите программу, которая принимает на вход пятизначное число
// и проверяет является ли оно палиндромом

// Можно попробовать решить через string или массив

Console.Clear();

System.Console.Write("Введите пятизначное число --> ");

string? number = Console.ReadLine();

void CheckNumber(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
}

if (number!.Length == 5)
{
    CheckNumber(number);
}
else System.Console.WriteLine("Введите пятизначное число --> ");
