using System;
class CurrencyConverterPhpUsd {
  static void Main(string[] args) {
    
    const decimal PHPToUSDRate = 57.04m;
    const decimal USDToPHPRate = 1/PHPToUSDRate;
    
    decimal amountUSD, amountPHP, convertedAmount;
    
    Console.WriteLine("======== CURRENCY CONVERTER ========");
    Console.WriteLine("[1] Convert USD to PHP\n[2] Convert PHP to USD\n");
    Console.Write("Choose an option (1 or 2): ");
    int option = int.Parse(Console.ReadLine());
    
    if (option == 1) {
        Console.Write("Enter amount in USD: ");
        amountUSD = decimal.Parse(Console.ReadLine());
        
        convertedAmount = amountUSD * PHPToUSDRate;
        
        Console.WriteLine($"{amountUSD:N2} USD is equal to {convertedAmount:N2} PHP");
    }
    else if (option == 2) {
        Console.Write("Enter amount in PHP: ");
        amountPHP = decimal.Parse(Console.ReadLine());
        
        //decimal convertedAmount = amountPHP/PHPToUSDRate;
        convertedAmount = amountPHP * USDToPHPRate;
        
        Console.WriteLine($"{amountPHP:N2} PHP is equal to {convertedAmount:N2} USD");
    }
    else {
        Console.WriteLine("Invalid option. Please select 1 or 2.");
    }
    
    Console.WriteLine("\nThank you for using the currency converter!");
    
  }
}