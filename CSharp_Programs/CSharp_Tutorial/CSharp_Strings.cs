using System;
class Program {
    static void Main() {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();
        Console.WriteLine("Length = " + s.Length);
        Console.WriteLine("Uppercase = " + s.ToUpper());
        Console.WriteLine("Lowercase = " + s.ToLower());
    }
}