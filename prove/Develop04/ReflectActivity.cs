using System.Text;

namespace Develop04;

public class ReflectActivity : Activity
{
    private DateTime _futureTime;
    public ReflectActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        _futureTime = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(5);
        while (_futureTime > DateTime.Now) {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }
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

    public string GetRandomQuestion()
    {
        string[] randomQuestions =
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        return randomQuestions[new Random().Next(0, randomQuestions.Length - 1)];
    }
}