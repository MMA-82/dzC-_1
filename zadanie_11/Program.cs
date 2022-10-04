Console.WriteLine("Ведите число");
int N = int.Parse(Console.ReadLine() ?? "0");
if(N % 5 == 0) Console.WriteLine("Введенное число кратно 5");
else Console.WriteLine("Введенное число не кратно 5");
