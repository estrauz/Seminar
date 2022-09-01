// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enter a size: ");
int size = Convert.ToInt32(Console.ReadLine());

int N = 1;
int index = 0;

while (index < size)
{
    Console.Write(Math.Pow(N, 3)+" ");
    N++;
    index++;
}



