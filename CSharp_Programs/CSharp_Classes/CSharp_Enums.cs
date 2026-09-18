using System;
enum Level { Low, Medium, High }
class Program {
    static void Main() {
        Console.Write("Enter level (0=Low, 1=Medium, 2=High): ");
        int n = int.Parse(Console.ReadLine());
        if (n >= 0 && n <= 2)
            Console.WriteLine("Selected = " + (Level)n);
        else
            Console.WriteLine("Invalid level");
    }
}