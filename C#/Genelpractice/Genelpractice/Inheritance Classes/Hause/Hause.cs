namespace Genelpractice.Inheritance_Classes;

public class Hause
{
    // Her Evde Olan Genel Özellikler Üst Ev Class ına Verilicek//
    internal int roomNumber;
    internal double squareMeters;
    internal string colour;

    internal virtual void ShowInfo()
    {
        Console.WriteLine($"Oda Sayısı:{roomNumber}");
        Console.WriteLine($"Renk:{colour}");
        Console.WriteLine($"Metrekare:{squareMeters}");
    }
}