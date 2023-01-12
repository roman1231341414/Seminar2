//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом

Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0]==number[0] || number[1]==number[3])
    {
        Console.WriteLine($"Ваше число:{number}-да");
    }
    else 
    {
        Console.WriteLine($"Ваше число:{number}-нет");
    }
}
if (number.Length == 5)
{
    CheckingNumber(number);
}
else
{
    Console.WriteLine($"Введите правильное число");
}