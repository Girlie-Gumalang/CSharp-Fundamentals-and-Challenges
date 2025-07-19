using System;
class RemoveCharacterByIndex {
  static void Main(string[] args) {
    
    string myString = "Programming"; // 11 letters
    
    Console.WriteLine(RemoveChar(myString, 1)); // remove second letter
    Console.WriteLine(RemoveChar(myString, 10)); // remove last letter
    Console.WriteLine(RemoveChar(myString, 0)); // remove first letter
    
    Console.WriteLine(myString.Remove(7)); // remove char start from index 7
  }
   static string RemoveChar(string s, int n) {
       return s.Remove(n, 1);
   }
}