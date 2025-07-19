using System;
class AgePrimeChecker {
  static void Main(string[] args) {

    Console.Write("Enter your age: ");
    int age = int.Parse(Console.ReadLine());
    
    if (IsPrime(age)) {
        Console.WriteLine("Your age is a prime number!");
    } else {
        Console.WriteLine("Your age is not a prime number.");
    }
  }
  
  static bool IsPrime(int age) {
    if (age <= 1) return false;
    
    for(int i = 2; i <= age/2; i++){
        if(age % i == 0) 
        return false;
    }
    return true;
  }
}