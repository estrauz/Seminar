 /* Задача 54:Задайте двумерный массив. Напишите программу, которая упорядочит 
 по убыванию элементы каждой строки двумерного массива.   */


int[,] matr = new int[7,7];

int tepm = 0;

GetMatrix(matr);
SortRows(matr);
PrintMartix(matr);


void GetMatrix( int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { 
            matrix[i,j] = new Random().Next(100);
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    
    }
    Console.WriteLine();

}

void SortRows (int[,] matrix)
{
    Console.WriteLine("Sorted matrix:");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
             
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int m = 0; m < matrix.GetLength(1) - 1; m++)
            {
                if (matrix[i,m] < matrix[i, m + 1])
                {
                    tepm = matrix[i, m + 1];
                    matrix[i, m + 1] = matrix[i,m];
                    matrix[i, m] = tepm;
                    
                }
            }
         
        }
    
    }
}

void PrintMartix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
}
