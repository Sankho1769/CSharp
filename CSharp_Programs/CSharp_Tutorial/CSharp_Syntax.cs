using System;
class Program {
    static void Main() {
        Console.Write("Enter two integers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum = " + (a + b));
    }
}