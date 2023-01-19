/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int userData(string msg)
{
    Console.WriteLine(msg);
    int user = int.Parse(Console.ReadLine());
    return user;
}

int skannumbers(int number)
{
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < number; i++)
    {
      advance = number - number% 10;
      result = result + (number - advance);
      number = number / 10;
    }
    return result;
}

int number = userData("Введите число");
int digit = skannumbers(number);
Console.WriteLine($"Сумма цифр в числе {digit}");
