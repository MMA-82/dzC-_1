Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine() ?? "0");
int x = N % 100 / 10;
Console.WriteLine("Вторая цифра введенного числа " + x);