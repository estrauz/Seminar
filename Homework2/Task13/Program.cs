using System;
 
class Program
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        string number1 = Convert.ToString(number);
        int size = number1.Length;

        if (size > 2)
        {
            Console.WriteLine("Third number is a " + number1[2]);
        }
        else
        {
            Console.WriteLine("There is no third number");
        };
        
    }
        
}


