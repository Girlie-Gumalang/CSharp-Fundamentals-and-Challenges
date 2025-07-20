using System;
class SpeedFromDistanceTime {
  static void Main(string[] args) {
    
    double distance, hours, minutes, seconds;
    
    Console.Write("Input distance(metres): ");
    distance = double.Parse(Console.ReadLine());
    
    Console.Write("Input hours: ");
    hours = double.Parse(Console.ReadLine());
    
    Console.Write("Input minutes: ");
    minutes = double.Parse(Console.ReadLine());
    
    Console.Write("Input seconds: ");
    seconds = double.Parse(Console.ReadLine());
    
    double totalSeconds = hours * 3600 + minutes * 60 + seconds;
    double mps = distance / totalSeconds;
    double kph = (distance / 1000) / (totalSeconds / 3600);
    double mph = kph / 1.609;
    
    Console.WriteLine($"Your speed in metres/sec is {mps:F6}");
    Console.WriteLine($"Your speed in km/h is {kph:F5}");
    Console.WriteLine($"Your speed in miles/h is {mph:F5}");
  }
}