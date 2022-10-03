Console.WriteLine("Введите число от 10 до 99");
int N = int.Parse(Console.ReadLine() ?? "0");
int a = N / 10;
int b = N % 10;
if(a > b) Console.WriteLine("Наибольшая цифра у введенного числа: " + a);
else Console.WriteLine("Наибольшая цифра у введенного числа: " + b);
