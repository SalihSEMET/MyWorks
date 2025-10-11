using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Chef_Robot : Restourant_Robot
    {
        public Chef_Robot(string robotName, int battary, int workhour) : base(robotName, battary, workhour)
        {

        }
        public override void StartWork()
        {
            Smart_Robot_State.Battary -= 5;
            Console.WriteLine($"{robotName} Yemek Yaptı Batarya Durumu:{Smart_Robot_State.Battary}");
        }
    }
}
