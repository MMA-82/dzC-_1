Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine() ?? "0");
if(N > 99)
{
    if(N < 1000)
    {
    int x = N % 10;
    Console.WriteLine("Третья цифра введенного числа " + x);
    }
    else Console.WriteLine("Введенное число имеет более трех цифр");
}
else Console.WriteLine("У введенного числа нет третьей цифры!");