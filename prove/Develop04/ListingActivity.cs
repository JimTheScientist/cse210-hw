namespace Develop04;

public class ListingActivity : Activity
{
    private DateTime _futureTime;
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int count = 0;
        _futureTime = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine(GetRandomPrompt());
        while (_futureTime > DateTime.Now)
        {
            Console.ReadLine();
            count += 1;
        }
        Console.WriteLine("You answered with " + count + " items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        string[] randomPrompts =
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."
        };
        return randomPrompts[new Random().Next(0, randomPrompts.Length - 1)];
    }

}