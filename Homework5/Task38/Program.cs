// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Write("Enter the elements of the array: ");
int elements = int.Parse(Console.ReadLine());

double[] arr = new double[elements];

void PrintArray (double[] array)  
{
    Console.Write("The array: ");

        for (int i =  0; i < array.Length; i++)
        {
            arr[i] = new Random().Next(0, 100);
        }
    Console.Write(String.Join(", ", array));
    Console.WriteLine(" ");
}

void Difference(double[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        double max = array[i];
        double min = array[i];

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > max) max = array[j];
            
            else 
                if (array[j] <= min) min = array[j];

        }
        Console.WriteLine($"Max = {max}, Min = {min}");

        double difference = max - min;
        Console.WriteLine($"Difference of Max to Min is {difference}");

        break;


    }
}


PrintArray(arr);
Difference(arr);