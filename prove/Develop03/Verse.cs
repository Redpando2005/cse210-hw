class Verse
{
        public List<string> RandomVerses(List<string> verse)
    {
        Random random = new Random();
        // Get a random count of verses (between 1 and the total number of verses)
        int count = random.Next(1, verse.Count + 1);
        List<string> selectedVerses = new List<string>();

        for (int i = 0; i < count; i++)
        {
            selectedVerses.Add(verse[i]);
        }

        return selectedVerses;
    }

}