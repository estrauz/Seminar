// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Enter a coordinate X1: ");
int X1 = int.Parse(Console.ReadLine());

Console.Write("Enter a coordinate Y1: ");
int Y1 = int.Parse(Console.ReadLine());

Console.Write("Enter a coordinate Z1: ");
int Z1 = int.Parse(Console.ReadLine());

Console.Write("Enter a coordinate X2: ");
int X2 = int.Parse(Console.ReadLine());

Console.Write("Enter a coordinate Y2: ");
int Y2 = int.Parse(Console.ReadLine());

Console.Write("Enter a coordinate Z2: ");
int Z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2));

Console.WriteLine($"Distance of A and B is {result:f2}");