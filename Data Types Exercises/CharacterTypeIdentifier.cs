using System;
class CharacterTypeIdentifier {
  static void Main(string[] args) {
    
    Console.Write("Input a symbol: ");
    char symbol = Convert.ToChar(Console.ReadLine());
    
    if ("aeiou".Contains(symbol)) {
        Console.WriteLine("It's a lowercase vowel.");
    }
    else if ("AEIOU".Contains(symbol)) {
        Console.WriteLine("It's an uppercase vowel.");
    }
    else if (char.IsLetter(symbol)) {
        Console.WriteLine("It's a consonant.");
    }
    else if (char.IsDigit(symbol)) {
        Console.WriteLine("It's a digit.");
    }
    else {
        Console.WriteLine("It's another symbol.");
    }
    
  }
}