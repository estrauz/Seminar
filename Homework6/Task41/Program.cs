/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Write("Enter quantity of numbers: ");

int quantity = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[quantity];
    
int count = 0;

void FillNumbers (int[] array)
{
    Console.Write("Enter the numbers: ");

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
               

        if (array[i] > 0) count++;  

    }
    
    if (count > 0) Console.WriteLine($"Positive numbers in this array are: {count}");
    else Console.WriteLine("There are no positive numbers in this array");

}



FillNumbers(arr);


