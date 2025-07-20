using System;
class BasicArithmeticOperation {
  static void Main(string[] args) {
    
    int firstNum, secondNum, result;
    char operation;
    
    Console.Write("Input first number: ");
    firstNum = int.Parse(Console.ReadLine());
    
    Console.Write("Input operation (+, -, *, /, %): ");
    operation = Convert.ToChar(Console.ReadLine());
    
    Console.Write("Input second number: ");
    secondNum = int.Parse(Console.ReadLine());

    switch (operation) {
        case '+':
            result = firstNum + secondNum;
            Console.WriteLine($"{firstNum} + {secondNum} = {result}");
            break;
        case '-':
            result = firstNum - secondNum;
            Console.WriteLine($"{firstNum} - {secondNum} = {result}");
            break;
        case '*':
            result = firstNum * secondNum;
            Console.WriteLine($"{firstNum} X {secondNum} = {result}");
            break;
        case '/':
            if (secondNum == 0) {
                Console.WriteLine("Cannot divide by zero.");
            } 
            else {
                result = firstNum / secondNum;
                Console.WriteLine($"{firstNum} / {secondNum} = {result}");
            }
            break;
        case '%':
            result = firstNum % secondNum;
            Console.WriteLine($"{firstNum} % {secondNum} = {result}");
            break;
        default:
            Console.WriteLine("Invalid operation.");
            break;
    }
    
  }
}