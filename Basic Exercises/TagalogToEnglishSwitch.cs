using System;
class TagalogToEnglishSwitch{
  static void Main(string[] args) {
    
    Console.Write("Enter a Tagalog number (1-10): ");
    string word = Console.ReadLine().ToLower();
    
    Console.WriteLine(EnglishTranslation(word));
  }
  
  static string EnglishTranslation(string word) {
    string translation;
    
    switch (word){
        case "isa":
            translation = "One";
            break;
        case "dalawa":
            translation = "Two";
            break;
        case "tatlo":
            translation = "Three";
            break;
        case "apat":
            translation = "Four";
            break;
        case "lima":
            translation = "Five";
            break;
        case "anim":
            translation = "Six";
            break;
        case "pito":
            translation = "Seven";
            break;
        case "walo":
            translation = "Eight";
            break;
        case "siyam":
            translation = "Nine";
            break;
        case "sampu":
            translation = "Ten";
            break;
        default:
            translation = "Not found.";
            break;
    }
    
    return $"English translation: {translation}";
  }
}
