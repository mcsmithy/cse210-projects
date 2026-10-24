class Scripture
{
    private Reference _reference;
    private List<Word> _scripture = [];
    private List<int> _visibleIndexes = [];

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        int i = 0;
        foreach (string word in text.Split(" "))
        {
            _scripture.Add(new Word(word));
            _visibleIndexes.Add(i++);
        }
    }

    public void Display()
    {
        Console.WriteLine($"{_reference.ReferenceAsString()}");
        foreach (Word word in _scripture)
        {
            word.Display();
            Console.Write(" ");
        }
    }

    public int HideWords()
    {
        Random rand = new Random();
        for (int i = 0; i < 3; i++)
        {
            if (_visibleIndexes.Count() == 0)
            {
                return 0;
            }
            int index = rand.Next(_visibleIndexes.Count());
            int val = _visibleIndexes[index];
            _scripture[val].Hide();
            _visibleIndexes.Remove(val);
        }
        return _visibleIndexes.Count();
    }
}