using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_İLkeleri_Devam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            citizen citizen = new citizen();

            Console.Write("Tc No Gir:");
            citizen.TCNO = Console.ReadLine();
        }
    }
}
