using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Server_Robot : Restourant_Robot
    {
        public Server_Robot(string robotName,int battary,int workhour) : base(robotName,battary,workhour)
        {
              
        }
        public override void StartWork()
        {
            Smart_Robot_State.Battary -= 19;
            Console.WriteLine($"{robotName} masalara yemek servis etti Batarya Durumu:{Smart_Robot_State.Battary}");
        }
    }
}
