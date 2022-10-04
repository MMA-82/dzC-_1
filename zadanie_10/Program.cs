Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine() ?? "0");
int result = (N/100)*10 + N%10;
Console.WriteLine("Убрали среднюю цифру числа: " + result);
