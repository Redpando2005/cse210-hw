class Reference
{
    private int _chapter;
    
    private string _book;

    private List<string> _verse;

    public Reference()
    {
        _chapter = 1;

        _book = "Book of Mormon";

        _verse = [
        "1 I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.", 
        "2 Yea, I make a record in the language of my father, which consists of the learning of the Jews and the language of the Egyptians.",
        "3 And I know that the record which I make is true; and I make it with mine own hand; and I make it according to my knowledge.",
        "4 For it came to pass in the commencement of the first year of the reign of Zedekiah, king of Judah, (my father, Lehi, having dwelt at Jerusalem in all his days); and in that same year there came many prophets, prophesying unto the people that they must repent, or the great city Jerusalem must be destroyed."
        ];
    }

    public Reference(int chapter, string book, List<string> verse)
    {
        _chapter = chapter;
        _book = book;
        _verse = verse;
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public List<string> GetVerses()
    {
        return _verse;
    }

}