using System;
class Program {
    static int Add(int a, int b) => a + b;
    static double Add(double a, double b) => a + b;
    static void Main() {
        Console.Write("Enter two decimal numbers: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Result = " + Add(a, b));
    }
}