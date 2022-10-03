Console.WriteLine("Введите число, до которого искать все четные");
int N = int.Parse(Console.ReadLine() ?? "0");
int x = 1;
while(x <= N)
{
    if(x % 2 == 0) Console.WriteLine( + x);
    x = x + 1;
}
