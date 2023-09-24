namespace Develop02;

public class Entry
{
    private DateTime _creationDate;
    private string _prompt;
    private string _response;
    
    // for new entries, makes the creation date now and generates a new prompt automatically.
    public Entry()
    {
        this._creationDate = DateTime.Now;
        this._prompt = GetNewPrompt();
    } 
    
    // for loading entries from the journal file
    public Entry(DateTime creationDate, string prompt, string response)
    {
        SetResponse(response);
        this._creationDate = creationDate;
        this._prompt = prompt;
    }

    public void SetResponse(string response)
    {
        this._response = response;
    }

    public string GetResponse()
    {
        return this._response;
    }

    public DateTime GetCreationDate()
    {
        return this._creationDate;
    }
    
    public string GetPrompt()
    {
        return this._prompt;
    }
    
    static string GetNewPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?", "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?", "What stood out to you more today than other days?",
            "What is your mother's maiden name?", "The name of your first elementary school?", "The three numbers on the back of your credit card?"
            // I can only describe the above joke as pure genius, please, hold your applause.
        };
        return prompts[new Random().Next(prompts.Count)];
    }
}