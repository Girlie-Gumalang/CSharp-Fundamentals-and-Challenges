using System;
class NegativeDivisibilityChecker {
  static void Main(string[] args) {

    int num1, num2;
    
    Console.Write("Enter first integer: ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Enter second integer: ");
    num2 = int.Parse(Console.ReadLine());
    
    Console.WriteLine($"One negative and other divisible by it? {IsOneNegativeAndDivisible(num1, num2)}");
  }
  
  static bool IsOneNegativeAndDivisible(int a, int b) {
    bool oneNegative = (a < 0) ^ (b < 0);
    bool divisible = (b != 0 && a % b == 0) || (a != 0 && b % a == 0);
    
    bool result = oneNegative && divisible;
    return result;
  }
}