using System;
class AverageSumOfFourNumbers {
  static void Main(string[] args) {
    
    int firstNum, secondNum, thirdNum, fourthNum, sum, ave;
    
    Console.Write("Enter first number: ");
    firstNum = int.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    secondNum = int.Parse(Console.ReadLine());
    Console.Write("Enter third number: ");
    thirdNum = int.Parse(Console.ReadLine());
    Console.Write("Enter fourth number: ");
    fourthNum = int.Parse(Console.ReadLine());
    
    sum = firstNum + secondNum + thirdNum + fourthNum;
    ave = sum/4;
    
    Console.WriteLine($"The average of {firstNum}, {secondNum}, {thirdNum}, {fourthNum}, is: {ave}");
  }
}