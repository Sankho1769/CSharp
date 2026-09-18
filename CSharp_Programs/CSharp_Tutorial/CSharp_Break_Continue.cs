using System;
class Program {
    static void Main() {
        Console.Write("Enter limit: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++) {
            if (i % 2 == 0) continue;
            if (i > 15) break;
            Console.Write(i + " ");
        }
    }
}