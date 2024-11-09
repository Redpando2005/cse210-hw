class Listing : Activity
{
    private static string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private static Random random = new Random();

    protected override void Run()
    {
        Console.WriteLine("Get Ready...");
        Thread.Sleep(1000);
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]);
        ShowSpinner(4);

        int count = 0;
        DateTime _startTime = DateTime.Now;

        while ((DateTime.Now - _startTime).TotalSeconds < _time)
        {
            Console.Write("Write a response: ");
            Console.ReadLine(); // Just read the item but don't store it
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        EndActivity();
    }
}