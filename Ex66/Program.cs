int M = Convert.ToInt32(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

int SumOfNumbers(int a, int b)
{
    if(a == b) return b;
    return (a + SumOfNumbers(a+1, b));
}

Console.WriteLine(SumOfNumbers(M, N));