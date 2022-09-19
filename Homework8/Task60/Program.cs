/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] matrix3D = new int[2,2,2];

FillMatrix(matrix3D);

int tepm = 0;

void FillMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                new Random().Next(10,100);
                Console.Write($"{matrix[i,j,k]} ");  

                }
               
            }
               
            
        }
        Console.WriteLine();
    
    }
    Console.WriteLine();
}

void ChangeEvenElement (int[,,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                for (int m = 0; m < matr.GetLength(2)-1; m++)
                {
                   if (matr[i,j,m] == matr[i,j,m+1])
                   {
                    matr
                   }


Console.Write($"{matr[i,j,k]} ({i},{j},{k})   ");