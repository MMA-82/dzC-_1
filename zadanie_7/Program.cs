Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine() ?? "0");
int x = N % 10;
Console.WriteLine("Последняя цифра введенного числа " + x);
