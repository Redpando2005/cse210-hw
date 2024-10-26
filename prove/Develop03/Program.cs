using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Clear the console screen
        Console.Clear();

        // Create a Reference object with predefined verses
        Reference reference = new Reference();

        // Get verses from the Reference object
        List<string> verses = reference.GetVerses();

        // Create a Verse object
        Verse verseHandler = new Verse();

        // Get random verses from the Verse class
        List<string> selectedVerses = verseHandler.RandomVerses(verses);

        // Create Word objects from the selected verses
        List<Word> wordObjects = Word.SplitVersesIntoWords(selectedVerses);

        // Display the selected verses
        DisplayVerses(reference, wordObjects);

        while (true)
        {
            // Prompt the user
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit:");
            string userInput = Console.ReadLine();

            // Check if the user wants to quit
            if (userInput.ToLower() == "quit")
            {
                break; // Exit the loop
            }

            // Hide random words in the selected verses
            HideRandomWords(wordObjects);

            // Clear the console screen
            Console.Clear();

            // Display the updated verses
            DisplayVerses(reference, wordObjects);

            // Check if all words are hidden
            if (AllWordsHidden(wordObjects))
            {
                Console.WriteLine("All words are hidden. Exiting program.");
                break;
            }
        }
    }

    // Method to display verses with book and chapter
    static void DisplayVerses(Reference reference, List<Word> wordObjects)
    {
        Console.WriteLine($"Book: {reference.GetBook()}, Chapter: {reference.GetChapter()}");
        Console.WriteLine("Selected Verses:");

        // Loop through each Word object and display its words
        foreach (var wordObj in wordObjects)
        {
            wordObj.DisplayWords(reference.GetBook(), reference.GetChapter());
        }
    }

    // Method to hide random words from the verses
    static void HideRandomWords(List<Word> wordObjects)
    {
        Random random = new Random();

        foreach (var wordObj in wordObjects)
        {
            // Randomly choose to hide 1 to 3 words
            int numberToHide = random.Next(1, 4); 
            List<int> randomIndexes = wordObj.GetRandomIndexes(numberToHide);
            wordObj.ReplaceWords(randomIndexes); // Replace selected words with "___"
        }
    }

    // Method to check if all words are hidden
    static bool AllWordsHidden(List<Word> wordObjects)
    {
        foreach (var wordObj in wordObjects)
        {
            if (wordObj.GetWords().Contains("___")) // Check if there are still visible words
            {
                return false;
            }
        }
        return true;
    }
}
