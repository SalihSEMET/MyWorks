namespace Genelpractice.Inheritance_Classes.Subclasses;
// -------------------------  : Kalıtım Alınıcak Üst Class Yazılır
public class DetachedHouse : Hause
{
    //Üst Class ın Özelliklerini Otomatik Aldı Kendine Ait Özellikler İse Buraya Yazılır
    internal double gardenSquareMeters;
    internal bool hasGarage;
    internal override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Bahçe Metrekaresi:{gardenSquareMeters}");
        Console.WriteLine($"Garaj Var mı ? :{0}",hasGarage ? "Var" : "Yok");
    }
}