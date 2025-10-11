using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Restourant
    {
        Restourant_Robot[] robots = new Restourant_Robot[0];

        internal void AddRobot(Restourant_Robot robot)
        {
            Array.Resize(ref robots, robots.Length + 1);
            robots[robots.Length - 1] = robot;
        }
        internal void StartService()
        {
            Console.WriteLine("----- *** Servis Başladı *** -----");
            foreach (Restourant_Robot robot in robots)
            {
                robot.StartWork();
            }
        }

    }
}
