using System;
class LeapYear {
  static void Main(string[] args) {
    
    while (true){
        try {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            
            if(year <= 0) {
                Console.WriteLine("Error: Please enter a year greater than 0.");
                continue;
            }
            
            if(IsLeapYear(year)) {
                Console.WriteLine($"{year} is a leap year.");
            }
            else {
                Console.WriteLine($"{year} is not a leap year.");  
            }
            
            break;
        }
        catch (FormatException) {
            Console.WriteLine("Error: Please enter a valid year.");
        }    
    }
  }
  
  static bool IsLeapYear(int year) {
    return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
  }
}