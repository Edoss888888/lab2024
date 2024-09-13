using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число n для вычисления n-го числа Фибоначчи: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int fibonacciNumber = Fibonacci(n);

        Console.WriteLine($"Число Фибоначчи F({n}) = {fibonacciNumber}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
