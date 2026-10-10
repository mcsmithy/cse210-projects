class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private Prompts _prompts = new Prompts();

    public void Display()
    {
        //foreach (var e in _entries)
        for (int i = 0; i < _entries.Count(); i++)
        {
            _entries[i].Display();
            if (i != _entries.Count()-1) { Console.WriteLine(); }
        }
    }

    public void Load(string filename)
    {
        _entries.Clear();
        foreach (string line in System.IO.File.ReadAllLines(filename))
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            int rating = int.Parse(parts[3]);

            Entry e = new Entry(date, prompt, response, rating);
            _entries.Add(e);
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var e in _entries)
            {
                outputFile.WriteLine(e.OneLine());
            }
        }
    }

    public void Write()
    {
        string prompt = _prompts.GeneratePrompt();
        Console.Write($"Prompt: {prompt}\nRecord thoughts: ");
        string response = Console.ReadLine();
        Console.Write("Rate your day (0-10): ");
        int rate = int.Parse(Console.ReadLine());
        Entry ent = new Entry(prompt, response, rate);
        _entries.Add(ent);
    }

    public int Size()
    {
        return _entries.Count();
    }
}