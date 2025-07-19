using System;
class Distance {
  static void Main(string[] args) {

    double kilometers, meters, centimeters, feet, inches;
    
    Console.Write("Enter distance between two cities in kilometers: ");
    kilometers = double.Parse(Console.ReadLine());
    
    meters = kilometers * 1000;
    centimeters = meters * 100;
    inches = centimeters / 2.54;
    feet = inches/12;
    
    Console.WriteLine("\nDistance Conversions:");
    Console.WriteLine("Meters " + meters + "\nCentimeters: " + centimeters + "\nFeet: " + feet + "\nInches: " + inches);
    
    Console.WriteLine("\nConverting in two decimal places:");
    Console.WriteLine("Meters " + Math.Round(meters, 2) + 
                    "\nCentimeters: " + Math.Round(centimeters, 2) + 
                    "\nFeet: " + Math.Round(feet, 2) + 
                    "\nInches: " + Math.Round(inches, 2));
  }
}
