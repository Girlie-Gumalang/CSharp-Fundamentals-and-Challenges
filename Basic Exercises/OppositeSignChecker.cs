using System;
class OppositeSignChecker {
  static void Main(string[] args) {

    int num1, num2;
    
    Console.Write("Enter first integer: ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Enter second integer: ");
    num2 = int.Parse(Console.ReadLine());
    
    Console.WriteLine($"One negative and one positive? {HasOppositeSigns(num1, num2)}");
  }
  
  static bool HasOppositeSigns(int a, int b) {
    return (a < 0) ^ (b < 0);
  }
}