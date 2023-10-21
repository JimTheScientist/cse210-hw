using System;
using Develop04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running Wellness Program");
        while (true)
        {
            Console.WriteLine("Choose and activity (1-4): \n1- Breathe\n2- Reflect\n3- List\n4- Quit");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}