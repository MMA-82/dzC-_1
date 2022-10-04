Console.WriteLine("Введите любое двузначное число");
int N = int.Parse(Console.ReadLine() ?? "0");
if(N <= 99)
{
    if(N >= 10)
    {
        int a = N / 10;
        int b = N % 10;
        if(a > b) Console.WriteLine("Наибольшая цифра у введенного числа: " + a);
        else Console.WriteLine("Наибольшая цифра у введенного числа: " + b);
    }
    else Console.WriteLine("Введено не двузначное число!!!");    
}
else Console.WriteLine("Введено не двузначное число!!!"); 