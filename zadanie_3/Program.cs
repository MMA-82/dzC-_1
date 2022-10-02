Console.WriteLine("Введите первое число");
int a = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число");
int b = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine("Введите третье число");
int c = int.Parse (Console.ReadLine() ?? "0");

if(a > b) 
{
  if(a > c) Console.WriteLine("Максимальное число " + a);
  else Console.WriteLine("Максимальное число " + c);
}
else
{
  if(b > c) Console.WriteLine("Максимальное число " + b);
  else Console.WriteLine("Максимальное число " + c);
}