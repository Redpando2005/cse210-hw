using System.Security.Cryptography;
class Reflection : Activity
{
    private static string[] Prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static string[] Questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?"
    };

    private static Random random = new Random();

    protected override void Run()
    {
        DateTime _startTime = DateTime.Now;
        Thread.Sleep(1000);
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]);
        Console.WriteLine("When you are ready press enter:");
        string userInput = Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to the experience.");
        Console.WriteLine($"You may begin soon");
        Thread.Sleep(1000);
        if (string.IsNullOrEmpty(userInput))
        {
            while ((DateTime.Now - _startTime).TotalSeconds < _time)
            {
                Console.WriteLine(Questions[random.Next(Questions.Length)]);
                ShowSpinner(20);
            }
        }
        EndActivity();
    }
}