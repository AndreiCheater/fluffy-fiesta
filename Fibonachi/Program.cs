﻿int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 10; i++)
{
    if (Fibonacci(i) <= 0)
    {
        Console.WriteLine("Попался, который кусался!");
        break;
    }
    Console.WriteLine(Fibonacci(i));
}