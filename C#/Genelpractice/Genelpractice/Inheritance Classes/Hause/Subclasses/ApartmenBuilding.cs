namespace Genelpractice.Inheritance_Classes.Subclasses;
// -------------------------  : Kalıtım Alınıcak Üst Class Yazılır
public class ApartmenBuilding : Hause
{
    //Üst Class ın Özelliklerini Otomatik Aldı Kendine Ait Özellikler İse Buraya Yazılır
    internal int flourNumber;
    internal bool hasElevator;
    internal override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Kaç Kat Var:{flourNumber}");
        Console.WriteLine($"Asansör Var Mı:{0}", hasElevator ? "Var" : "Yok");
    }
}