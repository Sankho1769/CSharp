using System;
class Program {
    static void Main() {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter operator (+ - * / %): ");
        char op = char.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        switch (op) {
            case '+': Console.WriteLine(a + b); break;
            case '-': Console.WriteLine(a - b); break;
            case '*': Console.WriteLine(a * b); break;
            case '/': Console.WriteLine(b == 0 ? "Cannot divide by zero" : (a / b).ToString()); break;
            case '%': Console.WriteLine(b == 0 ? "Cannot divide by zero" : (a % b).ToString()); break;
            default: Console.WriteLine("Invalid operator"); break;
        }
    }
}