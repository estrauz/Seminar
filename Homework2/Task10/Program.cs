// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Three-digit number: ");
int N = Convert.ToInt32(Console.ReadLine());

while (N / 100 >= 10 | N / 100 < 1)  
{
        Console.Write("Incorrect number! Right down a proper one: ");
        N = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine((N % 100) / 10);


