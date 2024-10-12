using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // List<double> x = new();
        // // x.Add (24.5);

        // Console.WriteLine("Hello Sandbox World!");

        // // gather data to fill up a list
        
        // double input = -1;
        // while(input != 0)
        // {
        //     Console.Write("Enter a number: ");
        //     string input_string= Console.ReadLine();
        //     input = double.Parse(input_string);
        //     x.Add(input);
        // }

        // foreach (double number in x)
        // {
        //     Console.WriteLine(number);
        // }

        Costume nurse = new Costume();
        nurse.headWear = "facemask";
        nurse.gloves = "nitrile";
        nurse.shoes = "orthopedic sneakers";
        nurse.upperGarment = "scrubs";
        nurse.lowerGarment = "scrubs";
        nurse.accessory = "stethoscope";

        Costume detective = new Costume();
        detective.headWear = "fedora";
        detective.gloves = "leather";
        detective.shoes = "loafers";
        detective.upperGarment = "trenchcoat";
        detective.lowerGarment = "slacks";
        detective.accessory = "magnifying glass";

        nurse.ShowWardrobe();
        detective.ShowWardrobe();
    }
}