using System;
class StudentMark {
  static void Main(string[] args) {

    int sum = 0, numOfSubjects, grade;
    double ave, converted;
    
    Console.Write("Enter the number of your subjects: ");
    numOfSubjects = int.Parse(Console.ReadLine());
    
    for(int i = 1; i <= numOfSubjects; i++) {
        Console.Write($"Enter grade for subject {i} : ");
        grade = int.Parse(Console.ReadLine());
        sum += grade;
    }
    
    ave = (double)sum/numOfSubjects;
    converted = Math.Round(ave, 2);
    
    Console.WriteLine($"\nTotal: {sum}\nAverage: {converted}");
  }
}