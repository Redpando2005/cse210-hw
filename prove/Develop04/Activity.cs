using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public abstract class Activity
{
    protected int _time;

    public void StartActivity(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName} Activity");
        Console.WriteLine(description);
        Console.Write("Enter the duration (in seconds) for this activity: ");

        if (int.TryParse(Console.ReadLine(), out _time) && _time > 0)
        {
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(4);
            Run();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }

    protected void ShowCountdown(int _time)
    {
        for (int i = _time; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected abstract void Run();

    protected void EndActivity()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the activity for {_time} seconds.");
        ShowSpinner(4);
    }

}