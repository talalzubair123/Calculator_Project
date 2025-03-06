using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b;
        Console.Write("Enter two numbers: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
       subtraction
       multiplication
        division

        if (b != 0)
            Console.WriteLine($"Quotient: {a / b}");
        else
            Console.WriteLine("Cannot divide by zero!");
        Console.WriteLine($"Product: {a * b}");
        multiplication

        Console.WriteLine($"Difference: {a - b}");
        subtraction

        Console.WriteLine($"Sum: {a + b}");
        addition
    }
}

