using System.IO.Compression;
using System.IO;
using System.Security.Cryptography.X509Certificates;
class Journal
{
    public List<string> _journalEntries = new();

    public void AddEntry(string response)
    {
        _journalEntries.Add(response);
    }

    public void DisplayEntries()
    {
        string[] lines = System.IO.File.ReadAllLines(fileName());
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public void SaveJournal()
    {
    Console.WriteLine("Saving File...");

    Console.WriteLine($"Please type a file name: ");
    string fileName = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
        foreach(string i in _journalEntries)
        {
            outputFile.WriteLine(i);
        }
    }
    }

    public string fileName()
    {
        Console.WriteLine("Please write a file name: ");
        string fileName = Console.ReadLine();
        return fileName;
    }

    // public void ReadFile()
    // {
    //     Console.WriteLine($"Please type a file name: ");
    //     string fileName = Console.ReadLine();
    //     string[] lines = System.IO.File.ReadAllLines(fileName);

    //     foreach (string line in lines)
    //     {
    //         Console.WriteLine(line);
    //     }
    // }
}