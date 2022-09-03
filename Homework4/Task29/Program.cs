// Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение . надо заполнить массив рандоными данными от минимального до максимального значение .И важное уточнениее , делать все в методе который возвращает массив
// 5, 1, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]

Console.Write("Enter elements of a array: ");
int elements = int.Parse(Console.ReadLine());

Console.Write("Enter a min number of the array: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Enter a max number of the array: ");
int max = int.Parse(Console.ReadLine());
 
int[] arr = new int[elements];

void PrintArray (int[] array)
{
    for (int i = 0; i < elements; i++)
    {   
        arr[i] = new Random().Next(min, max+1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(" ");
    
}
PrintArray(arr);
