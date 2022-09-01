int numberA = new Random().Next(0,99);
Console.WriteLine(numberA);

int numberB = new Random().Next(0,99);
Console.WriteLine(numberB);

if (numberA != numberB)
    if (numberA > numberB)
    {
        Console.Write("Максимальное число - ");
        Console.WriteLine(numberA);
        Console.Write("Минимальное число - ");
        Console.WriteLine(numberB);
    }
    else 
    {
        Console.Write("Максимальное число - ");
        Console.WriteLine(numberB);
        Console.Write("Минимальное число - ");
        Console.WriteLine(numberA);
    }
else 
{
    Console.WriteLine("Числа равные по значинию");
}
