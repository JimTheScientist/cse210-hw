namespace Learning03;

public class Fraction
{
    private int _top = 1;
    private int _bottom = 1;
    public Fraction() { } // the things above it set top and bottom to slim down code size :)

    public Fraction(int topNumber, int bottomNumber)
    {
        this._top = topNumber;
        this._bottom = bottomNumber;
    }

    public Fraction(int wholeNumber)
    {
        this._top = wholeNumber;
    }

    public int GetTop()
    {
        return this._top;
    }

    public void SetTop(int top)
    {
        this._top = top;
    }

    public int GetBottom()
    {
        return this._bottom;
    }

    public void GetBottom(int bottom)
    {
        this._bottom = bottom;
    }

    public string GetFractionString()
    {
        return this._top.ToString() + "/" + this._bottom;
    }

    public double GetDecimalValue()
    {
        return ((double)this._top) / ((double)this._bottom);
    }
    
}