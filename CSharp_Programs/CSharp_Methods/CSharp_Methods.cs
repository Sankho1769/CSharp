using System;
class Program {
    static int Add(int a, int b) => a + b;
    static void Main() {
        Console.Write("Enter two integers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum = " + Add(a, b));
    }
}