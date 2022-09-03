// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter a number A: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Enter a number B: ");
int B = int.Parse(Console.ReadLine());

int Method (int A, int B)
{
    int result = A;

    for (int i = 1; i < B; i++)  
    {
        result = result*A;
    }
    return result;
}

int number = Method(A, B);
Console.WriteLine($"The number is {number}");
