namespace Develop05;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public override void RecordEvent()
    {
        if (_amountCompleted < _target) _amountCompleted += 1;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override int GetPoints()
    {
        return _amountCompleted * Points + (_amountCompleted >= _target ? _bonus : 0);
    }

    public override string GetExtraInfo()
    {
        return " " + _amountCompleted + "/" + _target;
    }
    
    public override string GetStringRepresentation()
    {
        return "x0" + "\n" + ShortName + "\n" + Description + "\n" + Points + "\n" + _amountCompleted + "\n" + _target + "\n" + _bonus + "\n";
    }
}