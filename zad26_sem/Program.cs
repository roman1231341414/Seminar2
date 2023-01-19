int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine());
    return userData;
}

int getNumberOfDigit(int number)
{
    int numberOfDigit = 0;
    while(number > 0)
    {
     number = number / 10;
     numberOfDigit++;
    }
    return numberOfDigit;
}

int number = getUserData("Введите число");
int numberOfDigit = getNumberOfDigit(number);
Console.WriteLine($"В числе {number} = {numberOfDigit}");
