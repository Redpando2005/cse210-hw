namespace Sandbox2;

class Program
{
    static void AwesomeFunction(int x)
    {
        Console.WriteLine($"The arguments recieved by the awesome function is {x}.");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Howdy, Potato World!");
        AwesomeFunction(188999);
    }
}
