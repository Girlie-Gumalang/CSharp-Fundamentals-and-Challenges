using System;
class SumAndAverageForLoop {
  static void Main(string[] args) {
      
    int sum = 0;
    double average;
    
    Console.WriteLine("Input the 10 numbers");
    for (int i = 1; i <= 10; i++) {
        Console.Write($"Number {i} : ");
        int input = int.Parse(Console.ReadLine());
        sum += input;
    }
    
    average = (double)sum/10;
    
    Console.WriteLine($"The sum of 10 no. is : {sum}");
    Console.WriteLine($"The average is : {average}");
  }
}