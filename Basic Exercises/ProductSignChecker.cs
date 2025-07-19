using System;
class ProductSignChecker {
  static void Main(string[] args) {

    int num1, num2, product;
    
    Console.Write("Enter first integer: ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Enter second integer: ");
    num2 = int.Parse(Console.ReadLine());
    
    product = num1 * num2;
    string result = GetProductSign(product);
    Console.WriteLine($"\n{num1} X {num2} = {product}\n{result}");
    
  }
  
  static string GetProductSign(int prod) {
    if(prod < 0) {
        return "The product is negative.";
    }
    else if (prod > 0) {
        return "The product is positive.";
    }
    else {
        return "The product is zero.";
    }
  }
}