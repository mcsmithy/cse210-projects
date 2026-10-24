class Word
{
    private string _word;
    private bool _hidden = false;

    public Word(string word)
    {
        _word = word;
    }
    
    public void Display()
    {
        if (_hidden)
        {
            for (int i = 0; i < _word.Length; i++)
            {
                Console.Write("_");
            }
        }
        else
        {
            Console.Write(_word);            
        }
    }

    public void Hide()
    {
        _hidden = true;
    }
}