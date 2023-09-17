using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;

        Console.Write("Enter number: ");
          
        number = int.Parse(Console.ReadLine()); 
        while (number != 0) {
          numberList.Add(number);
          Console.Write("Enter number: ");
          number = int.Parse(Console.ReadLine()); 
        }
        int sum = 0;
        foreach (int num in numberList) {
          sum += num;
        }
        Console.WriteLine("The sum is: " + sum.ToString());
        float average = ((float) sum) / ((float)numberList.Count);
        Console.WriteLine("The average is: " + average.ToString());
        Console.WriteLine("The largest number is: " + numberList.Max().ToString());
    }
}
