public class Program
{
    public static void Main()
    {
        // List to hold different types of activities
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 12, 13), 30, 4.8), // Running activity
            new Cycling(new DateTime(2024, 12, 14), 45, 20),  // Cycling activity
            new Swimming(new DateTime(2024, 12, 15), 25, 40)  // Swimming activity
        };

        // Loop through each activity and display its summary
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}