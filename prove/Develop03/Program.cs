using System;
using System.Diagnostics.CodeAnalysis;
using Develop03;

/// <summary>
/// The program only hides words which have not yet been hidden.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Thus the heavens and the earth were finished, and all the host of them.",
            new Reference("Genesis", 2, 1));
        do
        {
            Console.Clear();
            Console.WriteLine(scripture._reference.GetReferenceText());
            Console.WriteLine(scripture.DisplayScripture());
            Console.WriteLine("\"quit\" to quit, or enter to continue hiding words");
            if (Console.ReadLine() == "quit")
            {
                break;
            }
        } while (scripture.RandomlyHideWords(3));
    }
}
