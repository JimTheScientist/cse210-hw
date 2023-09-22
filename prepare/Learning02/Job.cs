namespace Learning02;

public class Job
{
    public string _company = "";// set to empty string to prevent null errors because no constructor :)
    public string _jobTitle = "";// set to empty string to prevent null errors because no constructor :)
    public string _startYear = "";// set to empty string to prevent null errors because no constructor :)
    public string _endYear = "";// set to empty string to prevent null errors because no constructor :)
    

    public void Display()
    {
        System.Console.WriteLine(this._jobTitle + " (" + this._company + ") " + this._startYear + "-" + this._endYear);
    }
}