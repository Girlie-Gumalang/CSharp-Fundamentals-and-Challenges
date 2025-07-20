using System;
class UserLoginWithLimit {
  static void Main(string[] args) {
    
    const string UserID = "admin", UserPassword = "admin123";
    int attempts = 3;
    
    while(attempts > 0) {
       Console.Write("Enter user ID: "); 
       string userID = Console.ReadLine();
       
       Console.Write("Enter password: "); 
       string password = Console.ReadLine();
       
       if (userID.Equals(UserID) && password.Equals(UserPassword)) {
           Console.WriteLine("\nLogin Successful!");
           return;
       }
      
        attempts--;
        
        if(attempts == 0) {
           Console.WriteLine("Invalid credentials. No attempts left.\n");
           Console.WriteLine("User rejected.");
           break;
       }
        
        Console.WriteLine($"Invalid credentials. Attempts left: {attempts}\n");
    }
    
  }
}