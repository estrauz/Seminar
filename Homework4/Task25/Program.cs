
Console.Write("Enter a number A: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Enter a number B: ");
int B = int.Parse(Console.ReadLine());

int result = A;

for (int i = 1; i < B; i++)  
    {
    result = result*A;
    }
Console.WriteLine($"Number - {result}");

