using System;
class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("Square root = " + Math.Sqrt(n));
        Console.WriteLine("Square = " + Math.Pow(n, 2));
        Console.WriteLine("Absolute = " + Math.Abs(n));
    }
}