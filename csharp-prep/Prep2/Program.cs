using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string percentageText = Console.ReadLine();
        float percentage = float.Parse(percentageText);
        string letter;
        if (percentage >= 90f) {
          letter = "A";
        } else if (percentage >= 80f)
        {
          letter = "B";
        } else if (percentage >= 70f)
        {
          letter = "C";
        } else if (percentage >= 60f)
        {
           letter = "D"; 
        } else {
          letter = "F";
        }
        Console.WriteLine("Your grade is a " + letter);
        if (!((letter == "D") || (letter == "F"))) {
          Console.WriteLine("You passed");
        } else {
          Console.WriteLine("You failed");
        }
    }
}
