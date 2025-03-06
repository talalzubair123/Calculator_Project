using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b;
        Console.Write("Enter two numbers: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Product: {a * b}");
    }
}
