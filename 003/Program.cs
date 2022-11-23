void SqrAll(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i} -> {i * i * i}");
    }
}
Console.WriteLine("input N");
int N = Convert.ToInt32(Console.ReadLine());
SqrAll(N);
