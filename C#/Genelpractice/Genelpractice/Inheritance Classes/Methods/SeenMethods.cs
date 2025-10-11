namespace Genelpractice.Inheritance_Classes.Methods;

public static class SeenMethods
{
    public static void StandartSeen()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
    }

    public static void SuccessSeen(string message = "")
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        if (!string.IsNullOrEmpty(message))
        {
            Console.WriteLine(message);
        }
        Thread.Sleep(1500);
    }
    public static void SuccessSeen(int millisecound,string message = "")
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        if (!string.IsNullOrEmpty(message))
            Console.WriteLine(message);
        Thread.Sleep(millisecound);
    }
    public static void FailedSeen(string message = "")
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        if (!string.IsNullOrEmpty(message))
            Console.WriteLine(message);
        Thread.Sleep(1500);
    }
    public static void FailedSeen(int millisecound, string message = "")
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        if(!string.IsNullOrEmpty(message))
            Console.WriteLine(message);
        Thread.Sleep(millisecound);
    }
}