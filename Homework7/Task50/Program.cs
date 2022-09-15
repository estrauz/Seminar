/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 
17 -> такого числа в массиве нет */

int[,] matrix = new int[10,10];

Console.Write("Enter a number of row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number of column: ");
int column = Convert.ToInt32(Console.ReadLine());

RandomMatrix(matrix);
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
if (row < matr.GetLength(0) && row > 0 && 
    column < matr.GetLength(1) && column > 0) 
{
    Console.WriteLine($"Element [{row}, {column}] - the element included in the matrix. The value of that elemnet is {matrix[row,column]}");
}
    else Console.WriteLine($"That element [{row}, {column}] - that element NOT included in the matrix");
        

}
   

    
    
    


