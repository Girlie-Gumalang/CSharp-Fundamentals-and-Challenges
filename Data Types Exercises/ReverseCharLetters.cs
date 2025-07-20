using System;
class ReverseCharLetters {
  static void Main(string[] args) {
    
    char ch1, ch2, ch3;
    
    Console.Write("Enter letter: ");
    ch1 = Convert.ToChar(Console.ReadLine());
    Console.Write("Enter letter: ");
    ch2 = Convert.ToChar(Console.ReadLine());
    Console.Write("Enter letter: ");
    ch3 = Convert.ToChar(Console.ReadLine());
    
    Console.WriteLine($"{ch3}, {ch2}, {ch1}");
  }
}