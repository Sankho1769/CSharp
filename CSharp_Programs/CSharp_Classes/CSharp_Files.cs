using System;
using System.IO;
class Program {
    static void Main() {
        Console.Write("Enter text to save: ");
        string text = Console.ReadLine();
        string path = "csharp_output.txt";
        File.WriteAllText(path, text);
        Console.WriteLine("File written: " + path);
        Console.WriteLine("Content: " + File.ReadAllText(path));
    }
}