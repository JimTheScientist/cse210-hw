namespace Develop03;

public class Reference
{
    private int _startverse;
    private int _endverse;
    private int _chapter;
    private string _book;
    
    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startverse = verse;
        this._endverse = verse;
    }
    
    public Reference(string book, int chapter, int startverse, int endverse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startverse = startverse;
        this._endverse = endverse;
    }

    public string GetReferenceText()
    {
        if (_endverse > _startverse)
        {
            return this._book + " " + this._chapter + ":" + this._startverse + "-" + this._endverse;
        }

        return this._book + " " + this._chapter + ":" + this._startverse;
    }
}