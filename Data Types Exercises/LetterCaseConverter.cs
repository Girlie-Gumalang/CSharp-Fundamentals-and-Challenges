using System;
class LetterCaseConverter {
  static void Main(string[] args) {
    
    Console.Write("Enter a single character: ");
    char userInput = char.Parse(Console.ReadLine()); 

    if (char.IsUpper(userInput)) {
        Console.WriteLine($"The character {userInput} is an uppercase letter.\n" + 
                          $"Its lowercase version is {char.ToLower(userInput)}");
    }
    else if (char.IsLower(userInput)) {
        Console.WriteLine($"The character {userInput} is a lowercase letter.\n" + 
                          $"Its uppercase version is {char.ToUpper(userInput)}");
    }
    else {
        Console.Write($"The {userInput} is not a letter.");
    }
    
  }
}