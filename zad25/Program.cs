
int userData(string msg)
{
    Console.WriteLine(msg);
    int user = int.Parse(Console.ReadLine());
    return user;
}

int exponentiation(int A, int B)
{
    int sum = 1;
  for(int i = 0; i < B; i++)
  {
    sum = sum * A;

  }
  return sum;
}

int A = userData("Введите число А ");
int B = userData("Введите число B ");
int sum  = exponentiation( A, B);
Console.WriteLine($"число {A} в степени {B} = {sum}");
