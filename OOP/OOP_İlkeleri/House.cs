using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_İlkeleri
{
    class House
    {
        internal int roomNumber;
        internal string colour;
        internal double squareMeters;
        internal virtual void ShowInfo()
        {
            Console.WriteLine($"Oda Sayısı:{roomNumber}");
            Console.WriteLine($"Renk:{colour}");
            Console.WriteLine($"Metrekare:{squareMeters}");
        }

    }
}
