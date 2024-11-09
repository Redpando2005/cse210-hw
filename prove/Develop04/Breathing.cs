class Breathing : Activity
{
    protected override void Run()
    {
        DateTime _startTime = DateTime.Now; // Set the start time only once
        Console.WriteLine("Starting breathing exercise...");

        while ((DateTime.Now - _startTime).TotalSeconds < _time)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
        }
        EndActivity();
    }
}