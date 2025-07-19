using System;

class SumOfTwoNumbers {
    static void Main(string[] args) {
        
        int num1, num2, sum;
        
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
	// Can also be int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        sum = num1 + num2;
        Console.Write($"The sum of two numbers is {sum}");

    }
}