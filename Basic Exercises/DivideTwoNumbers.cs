using System;

class DivideTwoNumbers {
    static void Main(string[] args) {
        
        double dividend, divisor, quotient;
        
         try {
             Console.Write("Enter dividend: ");
             dividend = int.Parse(Console.ReadLine());
             Console.Write("Enter divisor: ");
             divisor = int.Parse(Console.ReadLine());
             
             if (divisor == 0) {
                 Console.WriteLine("Error: Cannot divide by zero");
             }
             else {
                 quotient = dividend/divisor;
                 Console.WriteLine($"The result of {dividend} / {divisor} = {quotient}");
             }
         } 
         catch (FormatException) {
             Console.WriteLine("Error: Please input valid integers.");
         }
    }
}