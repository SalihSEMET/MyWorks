namespace Genelpractice.Inheritance_Classes.Subclasses;
// -------------------------  : Kalıtım Alınıcak Üst Class Yazılır
public class Villa : Hause
{
    //Üst Class ın Özelliklerini Otomatik Aldı Kendine Ait Özellikler İse Buraya Yazılır
    internal bool hasPool, hasGarage;
    internal override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Garaj Var mı ? :{0}", hasGarage ? "Var" : "Yok");
        Console.WriteLine($"Havuz Var mı ? :{0}", hasPool ? "Var" : "Yok");
    }
}