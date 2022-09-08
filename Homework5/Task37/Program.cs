// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Enter the elements of the array: ");
int elements = int.Parse(Console.ReadLine());

int[] arr = new int[elements];


void PrintArray (int[] array)  
{
    Console.Write("The array: ");

    for (int i =  0; i < array.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    Console.Write(String.Join(", ", array));
    Console.WriteLine(" ");
}


void PairOfElements (int[] array)

{
    Console.Write("Pairs of the elements: ");

    for (int i = 0; i <= (array.Length/2); i++)
    {
        if (i == elements-1)
        {
            Console.Write(array[i] );

            break;
        }
        else 
        {
            int sum = array[i] + array[elements-1];
            Console.Write($"{sum}, ");
            elements--;

            if (elements-1 == i) break;

                     
        } 
        
    }
      
}

PrintArray(arr);
PairOfElements(arr);



        







