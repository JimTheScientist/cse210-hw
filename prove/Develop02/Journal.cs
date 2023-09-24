namespace Develop02;

public class Journal
{
    private string _name; // The file name and name of the journal
    public List<Entry> _entries = new List<Entry>();
    public static string FILE_ENDING = ".journal";
    public static string SEPARATOR = "-|~|-";
    public Journal(string name, bool newFile)
    {
        this._name = name;
        if (newFile == true)
        {
            CreateNewFile();
        }
        else
        {
            LoadEntries();
        }
    }

    private void LoadEntries()
    {
        string[] lines = System.IO.File.ReadAllLines(this._name + FILE_ENDING);
        foreach (string line in lines)
        {
            try
            {
                string[] parts = line.Split(SEPARATOR);
                string dateTimeStored = parts[0];
                string entryPrompt = parts[1];
                string response = parts[2];
                this._entries.Add(new Entry(new DateTime(long.Parse(dateTimeStored), DateTimeKind.Utc), entryPrompt, response));
            }
            catch (Exception e)
            {
                Console.WriteLine("No entries");
            }
        }
    }

    public void StoreEntries()
    {
        using (StreamWriter outputFile = new StreamWriter(this._name + FILE_ENDING))
        {
            foreach (Entry vEntry in _entries)
            {
                outputFile.WriteLine(vEntry.GetCreationDate().Ticks + SEPARATOR + vEntry.GetPrompt() + SEPARATOR + vEntry.GetResponse());
            }
        }
    }

    private void CreateNewFile()
    {
        File.Create(this._name + FILE_ENDING).Close();
    }

    public string GetName()
    {
        return this._name;
    }

}