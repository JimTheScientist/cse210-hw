namespace Develop05;

public class EternalGoal : Goal
{
    private int _timesCompleted = 0;
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public EternalGoal(string name, string description, int points, int timesCompleted) : base(name, description, points)
    {
        this._timesCompleted = timesCompleted;
    }
    public override void RecordEvent()
    {
        _timesCompleted += 1;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override int GetPoints()
    {
        return _timesCompleted * Points;
    }


    public override string GetStringRepresentation()
    {
        return "x1" + "\n" + ShortName + "\n" + Description + "\n" + Points + "\n" + _timesCompleted + "\n";
    }


}