using System;
class AbsoluteDifferenceCalculator {
  static void Main(string[] args) {
      
    int num1, num2, difference;
    
    Console.Write("Enter first number: ");
    num1 = int.Parse(Console.ReadLine());
    
    Console.Write("Enter second number: ");
    num2 = int.Parse(Console.ReadLine());
    
    difference = Math.Abs(num1 - num2);
    
    if (num1 > num2) {
        int result = DoubleValue(difference);
        Console.Write($"Result: {result}");
    }
    else {
        Console.Write($"Result: {difference}");
    }
    
  }
  
  static int DoubleValue (int diff) {
      return diff * 2;
  }
  
}