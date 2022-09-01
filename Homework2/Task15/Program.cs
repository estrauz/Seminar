Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number) 
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine(number+" - this is a business day");
        break;
    case 6:
    case 7:
        Console.WriteLine(number+" - this is a weekend");
        break;
    default:
        Console.WriteLine(number+" this a incorrect number");
        break;
}    
 
