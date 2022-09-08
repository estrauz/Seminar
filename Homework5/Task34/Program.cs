// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Enter the elements of the array: ");
int elements = int.Parse(Console.ReadLine());

int[] arr = new int[elements];

void PrintArray (int[] array)  
{
    Console.Write("The array: ");

        for (int i =  0; i < array.Length; i++)
        {
            arr[i] = new Random().Next(100, 1000);
            Console.Write($"{array[i]} ");
        }
    Console.WriteLine(" ");

}
void EvenNumbersOfArray (int[] array)
{ 
    int result = 0;

    Console.Write("Even numbers of this array are: ");

          
        for (int i =  0; i < arr.Length; i++)
        
            if (array[i] % 2 == 0) result ++;
                              
        Console.WriteLine($"{result}");
    
    if (result == 0) Console.Write("There are no even elements");
    
}
PrintArray(arr);
EvenNumbersOfArray(arr);

