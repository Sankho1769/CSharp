using System;
class Program {
    static void Main() {
        Console.Write("Enter a decimal number: ");
        double d = double.Parse(Console.ReadLine());
        int n = (int)d;
        Console.WriteLine("Explicit cast to int = " + n);
        Console.WriteLine("Implicit conversion back to double = " + n);
    }
}