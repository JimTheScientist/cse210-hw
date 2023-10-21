using System.Text;

namespace Develop04;

public class BreathingActivity : Activity
{
    private DateTime _futureTime;
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        _futureTime = DateTime.Now.AddSeconds(_duration);
        while (_futureTime > DateTime.Now)
        {
            System.Console.Write("Breathe in... 3");
            Thread.Sleep(1000);
            System.Console.Write("\b2");
            Thread.Sleep(1000);
            System.Console.Write("\b1");
            Thread.Sleep(1000);
            System.Console.Write("\nBreathe Out... 3");
            Thread.Sleep(1000);
            System.Console.Write("\b2");
            Thread.Sleep(1000);
            System.Console.Write("\b1\n");
            Thread.Sleep(1000);
        }
        DisplayEndingMessage();
    }
}