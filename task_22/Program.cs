//Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел 
// от 1 до N 

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;

while(i<= N)
{
    Console.Write(Math.Pow(i,2)+", ");
    i++;
}
