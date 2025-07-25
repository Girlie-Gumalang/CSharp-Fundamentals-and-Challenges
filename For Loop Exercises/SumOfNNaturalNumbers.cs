using System;
class SumOfNNaturalNumbers {
  static void Main(string[] args) {
      
    int sum = 0, terms; 
    
    Console.WriteLine("Display n terms of natural number and their sum:\n" + 
                      "----------------------------------------------\n");

    Console.Write("Input Value of terms : ");
    terms = int.Parse(Console.ReadLine());

    Console.Write($"\nThe first {terms} natural numbers are :\n");
    for (int i = 1; i <= terms; i++) {
        Console.Write(i + " ");
        sum += i;
    }
    
    Console.WriteLine($"\nThe Sum of Natural Number upto {terms} : {sum}");
  }
}