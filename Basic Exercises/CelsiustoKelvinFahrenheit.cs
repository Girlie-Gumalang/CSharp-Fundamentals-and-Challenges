using System;
class CelsiustoKelvinFahrenheit {
  static void Main(string[] args) {
    
    double celsius, kelvin, fahrenheit;
    
    Console.Write("Enter the amount of celsius: ");
    celsius = double.Parse(Console.ReadLine());
    
    kelvin = celsius + 273.15;
    fahrenheit = (9.0/5.0 * celsius) + 32;
    
    Console.WriteLine($"Kelvin = {kelvin}\nFahrenheit = {fahrenheit}");
  }
}