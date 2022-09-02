int M = Convert.ToInt32(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

int AkkermanFunction(int a, int b)
{
    if(a == 0) return b+1;
    if(b == 0) return AkkermanFunction(a-1, 1);
    return AkkermanFunction((a-1), AkkermanFunction(a, b-1));
}

Console.WriteLine(AkkermanFunction(M, N));
