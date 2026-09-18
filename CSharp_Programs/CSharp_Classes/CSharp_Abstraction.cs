using System;
abstract class Shape {
    public abstract double Area();
}
class Rectangle : Shape {
    private double width, height;
    public Rectangle(double w, double h) { width = w; height = h; }
    public override double Area() => width * height;
}
class Program {
    static void Main() {
        Console.Write("Enter width: ");
        double w = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double h = double.Parse(Console.ReadLine());
        Shape s = new Rectangle(w, h);
        Console.WriteLine("Area = " + s.Area());
    }
}