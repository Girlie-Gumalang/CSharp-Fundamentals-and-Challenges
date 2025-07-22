using System;
class ConvertVariousTypesToString {
  static void Main(string[] args) {
    
    Console.Write("Enter an integer: ");
    int intNum = int.Parse(Console.ReadLine());
    
    Console.Write("Enter a decimal/double number: ");
    double doubleNum = double.Parse(Console.ReadLine());
    
    Console.Write("Enter a word true or false: ");
    bool wordBool = bool.Parse(Console.ReadLine());
    
    Console.Write("Enter a single character: ");
    char singleChar = char.Parse(Console.ReadLine());
    
    string convertedInt = intNum.ToString();
    string convertedDouble = doubleNum.ToString();
    string convertedBool = wordBool.ToString();
    string convertedChar = singleChar.ToString();
    
    Console.WriteLine("\nConverted Values:");
    Console.WriteLine($"Integer to string: {convertedInt}\n" + 
                      $"Double to string: {convertedDouble}\n" +
                      $"Boolean to string: {convertedBool}\n" + 
                      $"Char to string: {convertedChar}" );
  }
}