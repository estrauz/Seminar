Console.Write("N: ");
int N = Convert.ToInt32(Console.ReadLine());

int countdown = 2;

while (countdown < N)
{
    Console.Write(countdown+" ");
    countdown += 2;
}

