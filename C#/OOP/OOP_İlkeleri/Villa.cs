using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_İlkeleri
{
    class Villa : House
    {
        internal bool hasPool;
        internal bool hasGarage;
        internal override void ShowInfo()
        {
            Console.WriteLine($"Oda Sayısı:{roomNumber}");
            Console.WriteLine($"Renk:{colour}");
            Console.WriteLine($"Metrekare:{squareMeters}");
            Console.WriteLine($"Garaj Var mı ? :{0}", hasGarage ? "Var" : "Yok");
            Console.WriteLine($"Havuz Var mı ? :{0}", hasPool ? "Var" : "Yok");
        }
    }
}
