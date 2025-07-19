using System;
class ArithmeticOperations {
  static void Main(string[] args) {
    
    int firstNum, secondNum, sum, difference, product, quotient, modulus;
    
    Console.Write("Input the first number: ");
    firstNum = int.Parse(Console.ReadLine());
    Console.Write("Input the second number: ");
    secondNum = int.Parse(Console.ReadLine());

    sum = firstNum + secondNum;
    difference = firstNum - secondNum;
    product = firstNum * secondNum;
    quotient = firstNum / secondNum;
    modulus = firstNum % secondNum;
    
    Console.WriteLine("\nOutput");
    Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
    Console.WriteLine($"{firstNum} - {secondNum} = {difference}");
    Console.WriteLine($"{firstNum} X {secondNum} = {product}");
    Console.WriteLine($"{firstNum} / {secondNum} = {quotient}");
    Console.WriteLine($"{firstNum} mod {secondNum} = {modulus}");
  }
}