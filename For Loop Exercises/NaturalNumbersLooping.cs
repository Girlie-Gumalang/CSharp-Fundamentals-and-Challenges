using System;
class NaturalNumbersLooping {
  static void Main(string[] args) {
      
    Console.WriteLine("Display the first 10 natural numbers:\n");
    Console.WriteLine("The first 10 natural number:\n");
    
    Console.WriteLine("For Loop:");
    for(int i = 1; i <= 10; i++){
        Console.Write(i + " ");
    }
    
    Console.WriteLine("\n\nWhile Loop:");
    int count = 1;
    
    while(count <= 10) {
        Console.Write(count + " ");
        count++;
    }
    
    Console.WriteLine("\n\nDo While Loop:");
    int counter = 1;
    
    do {
       Console.Write(counter + " "); 
       counter++;
       
    } while (counter <= 10);
    
  }
}