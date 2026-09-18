using System;
class Student {
    public string Name { get; set; }
    public int Marks { get; set; }
}
class Program {
    static void Main() {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter marks: ");
        int marks = int.Parse(Console.ReadLine());
        Student s = new Student { Name = name, Marks = marks };
        Console.WriteLine($"{s.Name}: {s.Marks}");
    }
}