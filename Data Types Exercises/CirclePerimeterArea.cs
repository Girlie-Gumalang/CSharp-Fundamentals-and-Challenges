using System;
class CirclePerimeterArea {
  static void Main(string[] args) {
    
    const double Pi = Math.PI;
    
    Console.Write("Input the radius of the circle: ");
    double radius = double.Parse(Console.ReadLine());
    
    double perimeter = 2 * Pi * radius;
    double area = Pi * radius * radius;
    
    Console.WriteLine($"Area: {area:F2}\nPerimeter: {perimeter:F5}");
  }
}