using System;
class SwapTwoNumbers {
  static void Main(string[] args) {
    
    int firstNum, secondNum, temp;
    
    Console.Write("Input the First Number: ");
    firstNum = int.Parse(Console.ReadLine());
    Console.Write("Input the Second Number: ");
    secondNum = int.Parse(Console.ReadLine());
    
    temp = firstNum;
    firstNum = secondNum;
    secondNum = temp;
    
    Console.WriteLine("After Swapping :");
    Console.WriteLine($"First Number: {firstNum}\nSecond Number : {secondNum}" );
    
  }
}