class Program
{
    static void Main()
    {
        // Create Address objects
        Address lectureAddress = new Address("427 Pleasent St", "New York", "NY", "10001");
        Address receptionAddress = new Address("888 Elm St", "Los Angeles", "CA", "90001");
        Address outdoorAddress = new Address("101 Clement St", "Pullman", "WA", "98101");

        // Create Event objects
        Lecture lecture = new Lecture("Time Travel: Possible?", "A big ball of wibbly wobbly, timey wimey stuff", DateTime.Now.AddDays(7), "10:00 AM", lectureAddress, "Dr. Who", 100);
        Reception reception = new Reception("Game Developer Conference", "An opportunity to network with game dev professionals.", DateTime.Now.AddDays(14), "6:00 PM", receptionAddress, "rsvp@GDC.com");
        Outdoor outdoorGathering = new Outdoor("Community Picnic", "Annual company picnic", DateTime.Now.AddDays(21), "12:00 PM", outdoorAddress, "Sunny with a chance of clouds");

        // Generate and display marketing messages
        Console.WriteLine("--- Standard Details ---");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(lecture.GetShortDescription("Lecture"));

        Console.WriteLine();

        Console.WriteLine("--- Standard Details ---");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(reception.GetShortDescription("Reception"));

        Console.WriteLine();

        Console.WriteLine("--- Standard Details ---");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(outdoorGathering.GetShortDescription("Outdoor Gathering"));
    }
}