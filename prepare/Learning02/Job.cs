
public class Job
{
    public string _company = "";
    public string _jobtitle = "";
    public int _startYear = 0;
    public int _endYear = 0;
    
    public void Display()
    {
        Console.WriteLine($"{_jobtitle} ({_company}) {_startYear}-{_endYear}");
    }
}