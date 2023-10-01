namespace Develop03;

public class Word
{
    public bool Hidden = false;
    private string _word;
    public Word(string word)
    {
        this._word = word;
    }

    public string getWord()
    {
        if (Hidden)
        {
            return new string('*', _word.Length);
        }
        else
        {
            return _word;
        }
    }
}