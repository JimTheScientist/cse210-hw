namespace Learning02;


public class Resume
{
    public string _name;
    public List<Job> _jobs;

    public void Display()
    {
        System.Console.WriteLine("Name: " + this._name);
        System.Console.WriteLine("Jobs:");
        foreach (Job job in this._jobs)
        {
            job.Display();
        }
    }
}