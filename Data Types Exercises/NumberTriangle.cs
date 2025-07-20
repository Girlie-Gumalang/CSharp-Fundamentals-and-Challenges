using System;
class NumberTriangle {
  static void Main(string[] args) {
    
    int number, width;
    
    Console.Write("Enter a number: ");
    number = int.Parse(Console.ReadLine());
    Console.Write("Enter the desired width: ");
    width = int.Parse(Console.ReadLine());
    
    Console.WriteLine("\nDecrease:");
    for(int row = 0; row < width; row++){
        for(int col = 0; col < width - row; col++){
            Console.Write(number);
        }
        Console.WriteLine();
    }
    
    Console.WriteLine("\nIncrease:");
    for(int row = 1; row <= width; row++){
        for(int col = 1; col <= row; col++){
            Console.Write(number);
        }
        Console.WriteLine();
    }

  }
}