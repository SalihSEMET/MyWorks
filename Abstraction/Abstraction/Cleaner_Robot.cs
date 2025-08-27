using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Cleaner_Robot : Restourant_Robot
    {
        public Cleaner_Robot(string robotName, int battary, int workhour) : base(robotName, battary, workhour)
        {

        }
        public override void StartWork()
        {
            Smart_Robot_State.Battary -= 7;
            Console.WriteLine($"{robotName} Temizlik Yaptı Batarya Durumu:{Smart_Robot_State.Battary}");
        }
    }
}
