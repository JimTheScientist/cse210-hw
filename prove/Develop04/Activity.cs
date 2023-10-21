namespace Develop04;

public class Activity
{
    private string _name;
    private string _description;
    public int _duration;

    public Activity(string name, string description)
    {
        this._description = description;
        this._name = name;
    }

    public void DisplayStartingMessage()
    {
        System.Console.WriteLine("~~ " + _name + " ~~");
        System.Console.WriteLine(_description + "\n\n");
        System.Console.WriteLine("How many seconds would you like to run this activity for?");
        _duration = Convert.ToInt32(System.Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("You have completed a " + _duration + " second " + _name);
        ShowSpinner(2);
    }

    public void ShowSpinner(int seconds)
    {
        int iter = 0;
        while (seconds > iter)
        {
            Console.Write("+--");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\b");
            Console.Write("\b");
            Console.Write("-+-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\b");
            Console.Write("\b");
            Console.Write("--+");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\b");
            Console.Write("\b");
            Console.Write("-+-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\b");
            Console.Write("\b");
            iter += 1;
        }
    }
}