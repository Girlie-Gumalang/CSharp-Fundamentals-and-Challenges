using System;
class RandomSumEvenChecker {
  static void Main(string[] args) {

    Random random = new Random();
    
    int firstNum = random.Next(100, 999);
    int secondNum = random.Next(100, 999);
    
    int sum = firstNum + secondNum;
    bool isEven = sum % 2 == 0;
    
    Console.WriteLine($"Random numbers: {firstNum}, {secondNum}");
    Console.WriteLine($"Sum: {sum}\nIs the sum even? {isEven}");
  }
}