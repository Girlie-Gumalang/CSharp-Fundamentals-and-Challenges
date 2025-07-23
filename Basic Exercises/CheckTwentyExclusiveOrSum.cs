using System;
class CheckTwentyExclusiveOrSum {
  static void Main(string[] args) {
      
    int num1, num2, sum;
    
    Console.Write("Enter first number: ");
    num1 = int.Parse(Console.ReadLine());
    
    Console.Write("Enter second number: ");
    num2 = int.Parse(Console.ReadLine());
    
    sum = num1 + num2;
    
    bool result = IsOneIntegerOrSumTwenty(num1, num2, sum);
    Console.Write(result);
  }
  
  static bool IsOneIntegerOrSumTwenty (int n1, int n2, int sum) {
      int twenty = 20;
        if ((n1 == twenty ^ n2 == twenty) || (sum == twenty)) {
            return true;
        }   
        else {
            return false;
        }
  }
}