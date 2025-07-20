using System;
class SphereSurfaceVolume {
  static void Main(string[] args) {
    
    const double Pi = Math.PI;
    
    Console.Write("Enter a radius of a sphere: ");
    double radius = double.Parse(Console.ReadLine());
    
    double surface = 4 * Pi * radius * radius;
    double volume = (4.0/3) * Pi * (radius * radius * radius);
    
    Console.Write($"Surface: {surface:F5}\nVolume: {volume:F5}");
    
  }
}