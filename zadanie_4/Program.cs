Console.WriteLine("Ведите число");
int N = int.Parse(Console.ReadLine() ?? "0");
if(N % 2 == 0) Console.WriteLine("Введенное число четное");
else Console.WriteLine("Введенное число нечетное");
