namespace Develop05;

public class GoalManager
{
    private List<Goal> _goals = new();

    public void Start()
    {
        Console.WriteLine("Welcome to the program, what would you like to do? \n" +
                          "1. Display info\n" +
                          "2. Create new goal\n" +
                          "3. Record goal\n" +
                          "4. Save goals\n" +
                          "5. Load goals");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                DisplayPlayerInfo();
                break;
            case 2:
                Console.WriteLine("Type: Eternal, Checklist, or Simple: ");
                CreateGoal(Console.ReadLine());
                break;
            case 3:
                Console.WriteLine("Goal name to record: ");
                RecordEvent(Console.ReadLine());
                break;
            case 4:
                SaveGoals();
                break;
            case 5:
                LoadGoals();
                break;
        }
        Start();
    }
    
    public void DisplayPlayerInfo()
    {
        int total = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine("  [" + (goal.IsComplete() ? "X" : " ") + "] " + goal.ShortName + " (" + goal.Description + ") " + goal.GetExtraInfo() + " Points: " + goal.GetPoints());
            total += goal.GetPoints();
        }
        Console.WriteLine("Total points: " + total);
    }

    public void CreateGoal(string type)
    {
        string name;
        string desc;
        int points;
        switch (type)
        {
            case "Eternal" or "1":
                Console.WriteLine("Name of the new goal: ");
                name = Console.ReadLine();
                Console.WriteLine("Description of the new goal: ");
                desc = Console.ReadLine();
                Console.WriteLine("Points to assign:");
                points = Int32.Parse(Console.ReadLine());
                this._goals.Add(new EternalGoal(name, desc, points));
                break;
            case "Simple" or "2":
                Console.WriteLine("Name of the new goal: ");
                name = Console.ReadLine();
                Console.WriteLine("Description of the new goal: ");
                desc = Console.ReadLine();
                Console.WriteLine("Points to assign:");
                points = Int32.Parse(Console.ReadLine());
                this._goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "Checklist" or "3":
                Console.WriteLine("Name of the new goal: ");
                name = Console.ReadLine();
                Console.WriteLine("Description of the new goal: ");
                desc = Console.ReadLine();
                Console.WriteLine("Points to assign:");
                points = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Target to assign:");
                int target = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Bonus to assign:");
                int bonus = Int32.Parse(Console.ReadLine());
                this._goals.Add(new ChecklistGoal(name, desc, points,target, bonus));
                break;
        }
    }

    public void RecordEvent(string eventTitle)
    {
        foreach (Goal goal in _goals)
        {
            if (goal.ShortName == eventTitle) goal.RecordEvent();
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("scores.txt"))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        _goals = new List<Goal>();
        string readText = File.ReadAllText("scores.txt");
        string[] lines = readText.Split("\n");
        int lineIndex = 0;
        while (lineIndex < lines.Length)
        {
            switch (lines[lineIndex])
            {
                case "x0":
                    // Checklist goal
                    _goals.Add(new ChecklistGoal(lines[lineIndex + 1], lines[lineIndex + 2],
                        Convert.ToInt32(lines[lineIndex + 3]),
                        Convert.ToInt32(lines[lineIndex + 4]), Convert.ToInt32(lines[lineIndex + 5]),
                        Convert.ToInt32(lines[lineIndex + 6])));
                    lineIndex += 7;
                    break;
                case "x1":
                    // Eternal Goal
                    _goals.Add(new EternalGoal(lines[lineIndex + 1], lines[lineIndex + 2], Convert.ToInt32(lines[lineIndex + 3]),
                                                       Convert.ToInt32(lines[lineIndex + 4])));
                    lineIndex += 5;
                    break;
                case "x2":
                    // Simple Goal
                    _goals.Add(new SimpleGoal(lines[lineIndex + 1], lines[lineIndex + 2], Convert.ToInt32(lines[lineIndex + 3]),
                        Convert.ToBoolean(lines[lineIndex + 4])));
                    lineIndex += 5;
                    break;
                default:
                    lineIndex += 1;
                    break;
            }
        }
    }
}