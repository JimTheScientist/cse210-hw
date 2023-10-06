using System;
using Learning04;
using Learning04.obj;

class Program
{
    static void Main(string[] args)
    {

        WritingAssignment writingAssignment = new WritingAssignment("European History", "Mary Waters",
            "The Causes of World War II");
        MathAssignment mathAssignment = new MathAssignment("Fractions", "Roberto Rodriguez", "7.3", "8-19");
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine(assignment.GetSummary());
    }
}