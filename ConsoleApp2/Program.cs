using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Найти периметр и длину диагонали");
        Console.Write("a = "); int a = Int32.Parse(Console.ReadLine());
        Console.Write("b = "); int b = Int32.Parse(Console.ReadLine());
        int P = 2 * a + 2 * b;
        double d = Math.Sqrt(a * a + b * b);
        Console.Write("Периметр = {0}   Длина диагонали = {1}", P, d);
        Console.ReadLine();
    }
}