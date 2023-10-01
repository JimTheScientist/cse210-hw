namespace Develop03;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    public Reference _reference;

    public Scripture(string scripture, Reference reference)
    {
        this._reference = reference;
        foreach (string word in scripture.Split(" "))
        {
            this._words.Add(new Word(word));
        }
    }

    public string DisplayScripture()
    {
        string returnString = "";
        foreach (Word qWord in _words)
        {
            returnString += qWord.getWord() + " ";
        }

        return returnString;
    }

    public bool RandomlyHideWords(int numberOfWords) // true if words were hidden, false if all are hidden
    {
        List<Word> unhidden = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.Hidden == false)
            {
                unhidden.Add(word);
            }
        }

        if (unhidden.Count == 0)
        {
            return false;
        }

        if (unhidden.Count < numberOfWords)
        {
            numberOfWords = unhidden.Count;
        }

        for (int i = 1; i <= numberOfWords; i++)
        {
            Word wordToUnhide = unhidden[new Random().Next(0, (unhidden.Count - 1))]; 
            wordToUnhide.Hidden = true;
            unhidden.Remove(wordToUnhide);
        }

        return true;
    }
    
}