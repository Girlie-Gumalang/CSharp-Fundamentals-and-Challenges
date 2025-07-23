using System;
class NearHundredOrTwoHundred {
  static void Main(string[] args) {
      
    int userInput;
    
    Console.Write("Input an integer: ");
    userInput = int.Parse(Console.ReadLine());
    
    bool result = CheckIntegerRange(userInput);
    Console.Write($"Is {userInput} within 20 of 100 or 200? {result}");
  }
  
  static bool CheckIntegerRange (int x) {
    if ((Math.Abs(x - 100)) <= 20 || (Math.Abs(x - 200)) <= 20) {
        return true;
    }
    else {
        return false;
    }
  }
  
}