// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Enter the elements of the array: ");
int elements = int.Parse(Console.ReadLine());

int[] arr = new int[elements];

void PrintArray (int[] array)  
{
    Console.Write("The array: ");

        for (int i =  0; i < array.Length; i++)
        {
            arr[i] = new Random().Next(1, 10);
            Console.Write($"{array[i]} ");
        }
    Console.WriteLine(" ");
}

void SumOddNumbersOfArray (int[] array)
{
    int sum = 0;

    Console.Write("Sum odd numbers of this array: ");

    for (int i =  0; i < arr.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum = sum + array[i];
        }
    
    }
Console.Write($"{sum} ");
}


PrintArray(arr);
SumOddNumbersOfArray(arr);

  
    






