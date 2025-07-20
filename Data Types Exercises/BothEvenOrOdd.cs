using System;
class BothEvenOrOdd {
  static void Main(string[] args) {
    
    int num1, num2;
    
    Console.Write("Enter first number: ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    num2 = int.Parse(Console.ReadLine());
    
    bool IsBothEven = (num1%2 == 0) && (num2%2 == 0);
    bool IsBothOdd = (num1%2 != 0) && (num2%2 != 0);
    
    if (IsBothEven){ 
        Console.WriteLine("Both numbers are even.");
    }
    else if (IsBothOdd) {
        Console.WriteLine("Both numbers are odd.");
    }
    else {
        if (num1%2 == 0) {
            Console.WriteLine($"{num1} is even and {num2} is odd");
        }
        else {
            Console.WriteLine($"{num2} is even and {num1} is odd");
        }
    }
    
  }
}