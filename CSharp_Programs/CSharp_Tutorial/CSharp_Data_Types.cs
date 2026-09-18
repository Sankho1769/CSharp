using System;
class Program {
    static void Main() {
        Console.Write("Enter an integer: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter a decimal: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter a character: ");
        char c = char.Parse(Console.ReadLine());
        Console.Write("Enter true/false: ");
        bool b = bool.Parse(Console.ReadLine());
        Console.WriteLine($"int={i}, double={d}, char={c}, bool={b}");
    }
}