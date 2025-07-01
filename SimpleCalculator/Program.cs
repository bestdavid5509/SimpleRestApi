// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");


using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine($"Sum: {sum}");
    }
}