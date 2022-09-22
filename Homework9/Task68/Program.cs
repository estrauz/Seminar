/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

Console.Write("Enter a number M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number N: ");
int N = Convert.ToInt32(Console.ReadLine());

CallFunction(M, N);

int FunctionAkkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (M > 0 && N == 0)
    {
        return FunctionAkkerman(M - 1, 1);
    }
    else if (M > 0 && N > 0)
    {
        return (FunctionAkkerman(M - 1, FunctionAkkerman(M, N - 1)));
    }
    else
        return N + 1;
}

void CallFunction(int M, int N)
{
    Console.Write(FunctionAkkerman(M, N)); 
}