using System;
class MultiplyThreeNumbers {
  static void Main(string[] args) {
    
    int firstNum, secondNum, thirdNum, product;
    
    Console.Write("Input the first number to multiply: ");
    firstNum = int.Parse(Console.ReadLine());
    Console.Write("Input the second number to multiply: ");
    secondNum = int.Parse(Console.ReadLine());
    Console.Write("Input the third number to multiply: ");
    thirdNum = int.Parse(Console.ReadLine());
    
    product = firstNum * secondNum * thirdNum;
    
    Console.WriteLine($"{firstNum} X {secondNum} X {thirdNum} = {product}");
  }
}