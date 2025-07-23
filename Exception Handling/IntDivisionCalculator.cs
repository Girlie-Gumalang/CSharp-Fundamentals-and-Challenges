using System;
class IntDivisionCalculator {
  static void Main(string[] args) {
      
    int num1, num2, result;
    
    try {
        Console.Write("Input the first number: ");
        num1 = int.Parse(Console.ReadLine());
            
        Console.Write("Input the second number: ");
        num2 = int.Parse(Console.ReadLine());

        result = num1 / num2;
        Console.WriteLine($"Result: {result}");
   
    } 
    catch (DivideByZeroException) {
        Console.WriteLine("Error: Cannot divide by zero.");     
    } 
    catch (FormatException) {
        Console.WriteLine("Error: Non-numeric value entered.");     
    } 
    catch (Exception ex) {
        Console.WriteLine("Unexpected error occurred: " + ex.Message); 
    }

  }
}
