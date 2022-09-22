/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
 элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Enter a number M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M <= 0 && N <= 0 || M <= 0 || N <= 0) 
{
    Console.WriteLine("You entered the incorrect number(s)"); 
    return;
}
int size = (N - M) + 1;
int sum = 0;

int[] arr = new int[size];

SumArray(arr);

void SumArray(int[] array)
{

   for (int i = 0; i < array.Length; i++)
   {
       array[i] = M;
       sum = sum + array[i];
       M++;
   }
Console.Write($"The sum of that array is {sum}");
}
