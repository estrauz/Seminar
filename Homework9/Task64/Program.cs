/* Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

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

int[] arr = new int[size];

FillArray(arr);

void FillArray(int[] array)
{
Console.Write("The array: ");
    
   for (int i = 0; i < array.Length; i++)
   {
       array[i] = M;
       Console.Write($"{array[i]} ");
       M++;
   }
}