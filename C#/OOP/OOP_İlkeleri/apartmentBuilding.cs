using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_İlkeleri
{
    class apartmentBuilding : House
    {
        internal int  flourNumber;
        internal bool hasElevator;

        internal override void ShowInfo()
        {
            Console.WriteLine($"Oda Sayısı:{roomNumber}");
            Console.WriteLine($"Renk:{colour}");
            Console.WriteLine($"Metrekare:{squareMeters}");
            Console.WriteLine($"Kaç Kat Var:{flourNumber}");
            Console.WriteLine($"Asansör Var mı ? :{0}", hasElevator ? "Var" : "Yok");
        }
    }
}
