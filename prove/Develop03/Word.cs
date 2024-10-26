class Word 
{
    private List<string> _words;


    public Word(string verse)
    {
        _words = new List<string>(verse.Split(' ')); // Split by spaces
    }

    // Method to get all words as a list
    public List<string> GetWords()
    {
        return _words;
    }

    // Static method to split a list of verses into Word objects
    public static List<Word> SplitVersesIntoWords(List<string> verses)
    {
        List<Word> words = new List<Word>();

        foreach (string verse in verses)
        {
            Word word = new Word(verse);
            words.Add(word);
        }

        return words;
    }

    public List<int> GetRandomIndexes(int numberOfIndexes)
    {
        Random random = new Random();
        List<int> indexes = new List<int>();

        // Pick random indexes up to the number requested
        for (int i = 0; i < numberOfIndexes; i++)
        {
            int index = random.Next(_words.Count);
            indexes.Add(index);
        }

        return indexes;
    }

    public void ReplaceWords(List<int> indexes)
    {
        foreach (int index in indexes)
        {
            _words[index] = "___";
        }
    }

    public void DisplayWords(string book, int chapter)
    {
        Console.WriteLine($"Book: {book}, Chapter: {chapter}"); // Print the book and chapter
        Console.WriteLine("Modified Verse:"); // Label for the verse

        // Use string.Join to create a single string of all words
        Console.WriteLine(string.Join(" ", _words)); // Print all words in one line, separated by spaces
    }
}