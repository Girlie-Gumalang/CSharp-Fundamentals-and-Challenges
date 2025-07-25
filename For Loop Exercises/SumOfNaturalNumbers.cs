using System;
class SumOfNaturalNumbers {
  static void Main(string[] args) {
      
    int sum = 0; 
    
    Console.WriteLine("Find the sum of first 10 natural numbers\n");
    Console.Write("The first 10 natural numbers are: ");
    for (int i = 1; i <= 10; i++) {
        Console.Write(i + " ");
        sum += i;
    }
    
    Console.WriteLine($"\nThe Sum is: {sum}");

  }
}