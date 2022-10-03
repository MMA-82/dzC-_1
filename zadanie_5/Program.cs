Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int x = N * (-1);
while(x <= N)
{
    Console.WriteLine( + x);
    x = x + 1;
}
