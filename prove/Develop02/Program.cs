using System;
using Develop02;

// The program does not do much special, but it does store the time in UTC Ticks, that way the actual time could be loaded into the program if needed.
// It adds a .journal file extension automatically, you do not need to add an extension yourself.

class Program
{
    private static Journal currentJournal;
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal program, please load a journal file or create a new one:\nCreate New (c)\nOpen (o)");
        string response = Console.ReadLine();
        if (response == "o")
        {
            Console.WriteLine("Journal File Path:");
            currentJournal =  new Journal(Console.ReadLine(), false);
        } else if (response == "c")
        {
            Console.WriteLine("Journal Name:");
            currentJournal =  new Journal(Console.ReadLine(), true);
        }

        while (true)
        {
            Console.WriteLine("Welcome to the Journal program. Please choose one of the following options:");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Load journal file");
            Console.WriteLine("4. Save journal file");
            Console.WriteLine("5. Quit");

            int action = int.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Entry newEntry = new Entry();
                    Console.WriteLine("New Journal Entry\nDate: " + newEntry.GetCreationDate().ToShortDateString() + "\n" + newEntry.GetPrompt());
                    newEntry.SetResponse(Console.ReadLine());
                    currentJournal._entries.Add(newEntry);
                    break;
                case 2:
                    Console.WriteLine("Reading from Journal: " + currentJournal.GetName());
                    foreach (Entry entry in currentJournal._entries)
                    {
                        Console.WriteLine("===============");
                        Console.WriteLine(entry.GetCreationDate().ToShortDateString());
                        Console.WriteLine(entry.GetPrompt());
                        Console.WriteLine(entry.GetResponse());
                    }

                    break;
                case 3:
                    Console.WriteLine("Journal File Path:");
                    currentJournal =  new Journal(Console.ReadLine(), false);
                    break;
                case 4:
                    currentJournal.StoreEntries();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
            }

        }
    }

}
