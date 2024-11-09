using System;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new Breathing(),
                "2" => new Reflection(),
                "3" => new Listing(),
                "4" => null,
                _ => null
            };

            if (activity == null)
            {
                Console.WriteLine("Exiting the program.");
                break;
            }

            activity.StartActivity(
                activity.GetType().Name.Replace("Activity", ""),
                GetDescription(choice)
            );
        }
    }

    private static string GetDescription(string choice)
    {
        return choice switch
        {
            "1" => "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
            "2" => "This activity will help you reflect on times in your life when you have shown strength and resilience.",
            "3" => "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
            _ => ""
        };
    }
}