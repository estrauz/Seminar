/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
 находить строку с наименьшей суммой элементов.*/

Console.Write("Enter a number of row and (or) column: ");
int row = Convert.ToInt32(Console.ReadLine());

int column = row;

int[,] matr = new int[row,column];

int SumRow = 0;
int MinSum = row * 9;   //  Максимальная сумма элементов в строчке, если Random до 10
int MinRow = 0;
int EvenSum = 0;

CreateMatrix(matr);
MinRowElement(matr);


void CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { 
            matrix[i,j] = new Random().Next(10);
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    
    }
    Console.WriteLine();

}

void MinRowElement(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRow = SumRow + matrix[i, j]; 
        }
        if (SumRow <= MinSum)
        {
            if (SumRow == MinRow) EvenSum++;
            MinSum = SumRow;
            SumRow = 0;
            MinRow++;


        }
        
        
    }
    if (EvenSum == 0) Console.WriteLine($"Sum minimum row is: {MinRow} row");
    else Console.WriteLine($"Sum minimum rows are: {MinRow} row or other row");
}

