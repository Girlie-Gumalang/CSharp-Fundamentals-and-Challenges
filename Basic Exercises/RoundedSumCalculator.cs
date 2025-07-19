using System;
class RoundedSumCalculator {
  static void Main(string[] args) {

    Console.Write("Enter first floating-point number: ");
    double num1 = double.Parse(Console.ReadLine());
    Console.Write("Enter second floating-point number: ");
    double num2 = double.Parse(Console.ReadLine());
    
    int rounded1 = (int) Math.Round(num1);
    int rounded2 = (int) Math.Round(num2);
    int sum = rounded1 + rounded2;
    
    Console.WriteLine($"Rounded values: {rounded1}, {rounded2}");
    Console.WriteLine($"Sum: {sum}");
  }
}