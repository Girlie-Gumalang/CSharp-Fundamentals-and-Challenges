using System;
class MultiplicationTable {
  static void Main(string[] args) {
    
    int num, product, counter;
    Console.Write("Enter the number: ");
    num = int.Parse(Console.ReadLine());
    
    counter = 0;
    
    while (counter <= 10) {
        product = num * counter;
        Console.WriteLine($"{num} X {counter} = {product}");
        counter++;
    }
  }
}