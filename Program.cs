using System;

class Program
{
    static void Main()
    {
        string greeting = GetGreeting();
        Console.WriteLine(greeting);
    }

    static string GetGreeting()
    {
        int hour = DateTime.Now.Hour;
        
        var greetings = new Dictionary<Func<int, bool>, string>
        {
            { h => h >= 5 && h < 12, "God morgen!" },
            { h => h >= 12 && h < 18, "God ettermiddag!" },
            { h => h >= 18 && h < 22, "God kveld!" },
            { h => h >= 22 || h < 5, "God natt!" }
        };

        foreach (var entry in greetings)
        {
            if (entry.Key(hour))
            {
                return entry.Value;
            }
        }

        return "Hei!";
    }
}
