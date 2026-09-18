using System;
class Program {
    static void Main() {
        Console.Write("Enter first integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("a > b = " + (a > b));
        Console.WriteLine("a == b = " + (a == b));
    }
}