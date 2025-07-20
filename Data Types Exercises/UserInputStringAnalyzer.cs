using System;
class UserInputStringAnalyzer {
  static void Main(string[] args) {
    
    Console.Write("Enter a word or phrase: ");
    string word = Console.ReadLine();
    
    int wordLength = word.Length;
    char firstChar = word[0];
    char lastChar = word[word.Length-1];
    
    Console.Write($"Length {wordLength}\nFirst character: {firstChar}\nLast Character: {lastChar}");
  }
}
