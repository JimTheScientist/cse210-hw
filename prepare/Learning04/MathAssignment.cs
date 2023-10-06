namespace Learning04;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string topic, string studentName, string textbookSection, string problems) : base(studentName, topic)
    {
        this._textbookSection = textbookSection;
        this._problems = problems;
    }
    
    public string GetHomeworkList()
    {
        return "Section " + this._textbookSection + " Problems " + this._problems;
    }
}