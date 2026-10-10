public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;
    private int _rating;

    public Entry(string prompt, string response, int rating){
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToString("yyyy/MM/dd");
        _rating = rating;
    }

    public Entry(string date, string prompt, string response, int rating){
        _prompt = prompt;
        _response = response;
        _date = date;
        _rating = rating;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine($"Rating: {_rating}/10");
    }

    public string OneLine()
    {
        return $"{_date}|{_prompt}|{_response}|{_rating}";
    }
}