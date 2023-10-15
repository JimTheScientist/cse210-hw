namespace Develop05;

public abstract class Goal
{
    public string ShortName { get; }
    public string Description { get; }
    public int Points { get; }

    public Goal(string name, string description, int points)
    {
        ShortName = name;
        Description = description;
        Points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetExtraInfo()
    {
        return " ";
    }
    public abstract int GetPoints();
    public abstract string GetStringRepresentation();

}