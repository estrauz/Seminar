using System;
 
class Program
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = System.Convert.ToInt32(Console.ReadLine());
                        
        string text = Convert.ToString(number);
        int size = text.Length;

        if (text[0] == text[4] && text[1] == text[3])
        {
        Console.WriteLine($"{number} - this is a palindrome");
        }
        else
        {
        Console.WriteLine($"{number} - this is NOT a palindrome or incorrect number");
        }
    }
}
