/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
двух матриц.
 */


Console.Write("Enter a number of first row: ");
int row1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number of first column: ");
int column1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number of second row: ");
int row2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number of second column: ");
int column2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[row1, column1];
int[,] matrix2 = new int[row2, column2];

if (row1 != column2) 
{ 
    Console.WriteLine("Multiplication is impossible");
    return;
}

FillMatrix(matrix1);
FillMatrix(matrix2);
PrintMartix(Multiplication(matrix1, matrix2));

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        { 
            matr[i,j] = new Random().Next(-10,10);
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    
    }
    Console.WriteLine();
}


int[,] Multiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
 
    for (int i = 0; i < matrix1.GetLength(0); ++i)
    {      
        for (int j = 0; j < matrix2.GetLength(0); ++j)
        {
            for (int k = 0; k < matrix2.GetLength(1); ++k)
            {
                matrix3[i, k] += matrix1[i, j] * matrix2[j, k];
            }
        }

    }
return matrix3;
}

void PrintMartix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write(matr[i, j] + " ");
    }
    Console.WriteLine();
  }
}
