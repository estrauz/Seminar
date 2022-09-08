// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Enter the elements of the array: ");
int elements = int.Parse(Console.ReadLine());

int[] arr = new int[elements];

// Метод для упрощаения проверки, например:
// Элементы массивы: 0  1  2  3  4  5  6  7  8
//      int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void EasyToCheck (int[] array)  
{
    Console.Write("The index: ");

        for (int i =  0; i < arr.Length; i++)
        {
            Console.Write($"{i}  ");
        }
    Console.WriteLine(" ");
}

void PrintArray (int[] array)  
{
    Console.Write("The array: ");

        for (int i =  0; i < array.Length; i++)
        {
            arr[i] = new Random().Next(1, 100);
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
        if (array[i] % 2 > 0)
        {
            sum = sum + i;
        }
    
    }
Console.Write($"{sum} ");
}

EasyToCheck(arr);
PrintArray(arr);
SumOddNumbersOfArray(arr);

  
    






