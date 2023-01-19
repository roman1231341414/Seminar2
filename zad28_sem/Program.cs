// N? от 1 до N произведение

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine());
    return userData;
}

int getProductOfNumbers(int number)
{
    int sum = 1;
    for (int i = 1; i <= number; i++)
    {
        sum = sum * i;
    }
    return sum;
}
int number = getUserData("Введите число N ");
int sum = getProductOfNumbers(number);
Console.WriteLine($"Произведение число от 1 до N = {sum}");
