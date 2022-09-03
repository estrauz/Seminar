// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter a number: ");
int N = int.Parse(Console.ReadLine());

string length = Convert.ToString(N);

int SumDigit (int N)
{
    int result = 0;

    for (int i = 0; i < length.Length; i++)
    {
        result = result + N % 10;
        N = N / 10;
    }
    return result;
}

int sum = SumDigit(N);
Console.WriteLine($"The number is {sum}");