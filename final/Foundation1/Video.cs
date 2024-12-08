class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comments> CommentsList;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        CommentsList = new List<Comments>();
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine("Comments:");
        foreach (var comment in CommentsList)
        {
            Console.WriteLine($"- {comment._commenter}: {comment._commentText}");
        }
        Console.WriteLine();
    }
}