namespace Develop05;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        this._isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int GetPoints()
    {
        return _isComplete ? Points : 0;
    }

    public override string GetStringRepresentation()
    {
        return "x2" + "\n" + ShortName + "\n" + Description + "\n" + Points + "\n" + _isComplete + "\n";
    }
}