/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 
17 -> такого числа в массиве нет */

Console.Write("Enter a number of row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number of column: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row,column];

RandomMatrix(matrix);

Console.Write("Request the element: ");
int number = Convert.ToInt32(Console.ReadLine());

FindElement(matrix);

void RandomMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0, 100); // [0;99]
            Console.Write($"{matr[i,j]}  ");
        }
    Console.WriteLine();
    }
}

void FindElement (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (number == matr[i,j]) 
            {
                Console.WriteLine($"{matr[i,j]} - the number included in the matrix");
            }
            else Console.WriteLine($"{number} - that number NOT included in the matrix");
        }

    }
}    

    
    
    


