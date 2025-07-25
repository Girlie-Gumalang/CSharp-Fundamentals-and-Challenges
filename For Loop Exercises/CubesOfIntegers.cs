using System;
class CubesOfIntegers {
  static void Main(string[] args) {
      
    Console.Write("Input number of terms : ");
    int terms = int.Parse(Console.ReadLine());
    
    for (int i = 1; i <= terms; i++) {
        Console.WriteLine($"Number is : {i} and cube of the {i} is: {i * i * i}");
    }
  }
}