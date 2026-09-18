using System;
class Program {
    static void Main() {
        Console.Write("Enter numerator: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter denominator: ");
        double b = double.Parse(Console.ReadLine());

        try {
            if (b == 0) throw new DivideByZeroException();
            Console.WriteLine("Result = " + (a / b));
        }
        catch (DivideByZeroException) {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}