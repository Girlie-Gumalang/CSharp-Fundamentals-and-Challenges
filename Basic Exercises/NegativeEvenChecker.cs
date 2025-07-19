using System;
class NegativeEvenChecker {
  static void Main(string[] args) {

    int num1, num2;
    
    Console.Write("Enter first integer: ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Enter second integer: ");
    num2 = int.Parse(Console.ReadLine());
    
    Console.WriteLine($"Exactly one negative even? {IsExactlyOneNegativeInteger(num1, num2)}");
  }
  
  static bool IsExactlyOneNegativeInteger(int a, int b) {
    bool aa = (a < 0) && (a % 2 == 0);
    bool bb = (b < 0) && (b % 2 == 0);
    
    bool result = aa ^ bb;
    
    return result;
  }
}