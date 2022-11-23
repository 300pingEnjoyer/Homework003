void FindPalindrom(int num)
{
int ed = num % 10;
int dec = num / 10 % 10;
int sot = num / 100 % 10;
int tic = num / 1000 % 10;
int dec_tic = num / 10000;
if (ed == dec_tic && dec == tic )
{
    Console.WriteLine("является палидромом");
}
else
{
    Console.WriteLine("не является палидромом");   
}
}
Console.WriteLine("input number");
int num = Convert.ToInt32(Console.ReadLine());
FindPalindrom(num);