using System;
class Program {
    static void Main() {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            numbers[i] = int.Parse(Console.ReadLine());

        Console.Write("Array: ");
        foreach (int x in numbers)
            Console.Write(x + " ");
    }
}