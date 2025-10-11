/*OOP İlkeleri
 1)Inheritance
 2)Encapsulation
 3)Polymorphsym
 4)Abstraction
*/

using Genelpractice.Inheritance_Classes;
using Genelpractice.Inheritance_Classes.Methods;
using Genelpractice.Inheritance_Classes.Subclasses;
using Inheritance;

namespace Genelpratice
{
    class Program()
    {
        static void Main()
        {
            Inheritance.HouseInheritance houseInheritance = new HouseInheritance();
            houseInheritance.Start();
        }
    }
}
namespace Inheritance
{
 /* Üst Classlar dan Alt Class lara Özelliklerin Aktarılması ve Tiplerin Tek Bir Çatı Altında Toplanması Durumudur
    C# da Çoklu Kalıtım Dogrudan Mümkün Değildir ama Dolaylı Yoldan Yapılabilir
  */
 class HouseInheritance
 {
     public void Start()
     {
         Hause[] hauses = new Hause[5];
         DetachedHouse detachedHouse = new DetachedHouse();
         ApartmenBuilding apartmenBuilding = new ApartmenBuilding();
         Villa villa = new Villa();
         hauses[0] = detachedHouse;
         hauses[1] = apartmenBuilding;
         hauses[2] = villa;
         while (true)
         {
             ConsoleKey consoleKey = GetMethods.Menu();
             switch (consoleKey)
             {
                 case ConsoleKey.E:
                     GetMethods.addHause(ref hauses, GetMethods.HauseAddInfoGet());
                     break;
                 case ConsoleKey.L:
                     GetMethods.ListHouses(ref hauses);
                     break;
                 case ConsoleKey.Q:
                     SeenMethods.SuccessSeen(2500, "Çıkış Yapılıyor...");
                     SeenMethods.SuccessSeen("Çıkış Yapıldı");
                     return;
             }
         }

     }
 }
}

