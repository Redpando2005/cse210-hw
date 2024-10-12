using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Entry myEntry = new Entry();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Write a new entry
                    string prompt = myEntry.generatePrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    string savedEntry = myEntry.saveResponse(prompt, response);
                    myJournal.AddEntry(savedEntry);
                    Console.WriteLine("Entry added successfully!");
                    break;

                case "2": // Display journal entries
                    myJournal.DisplayEntries();
                    break;

                case "3": // Save journal to a file
                    myJournal.SaveJournal();
                    Console.WriteLine("Journal saved successfully!");
                    break;

                case "4": // Load journal from a file
                    myJournal.fileName();  // Call the ReadFile method to load and display the journal
                    break;

                case "5": // Exit
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
