using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = (new Random()).Next(1,100);
        string response = "";
        Console.WriteLine("What is your guess?");
        response = Console.ReadLine();
        while (response != magicNumber.ToString()) {
            if (int.Parse(response) > magicNumber) {
                Console.WriteLine("Lower");
            } else {
                Console.WriteLine("Higher");
            }
            Console.WriteLine("What is your guess?");
            response = Console.ReadLine();
        }
        Console.WriteLine("You guessed it!");
        //Console.WriteLine(magicNumber.ToString());
    }
}
