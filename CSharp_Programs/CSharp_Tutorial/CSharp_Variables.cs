using System;
class Program {
    static void Main() {
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());
        Console.WriteLine($"Age = {age}\nSalary = {salary}");
    }
}