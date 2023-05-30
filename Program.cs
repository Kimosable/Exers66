// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = SumOfNumbers(m, n);

        Console.WriteLine("Сумма натуральных чисел в промежутке [{0}, {1}] равна {2}", m, n, sum);
    }

    static int SumOfNumbers(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        else if (m < n)
        {
            return m + SumOfNumbers(m + 1, n);
        }
        else
        {
            return n + SumOfNumbers(m, n + 1);
        }
    }
}