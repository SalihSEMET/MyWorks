using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restourant restourant = new Restourant();
            Server_Robot server_Robot = new Server_Robot("Garson Robot", 85, 2);
            Chef_Robot chef_Robot = new Chef_Robot("Şef Robot", 100, 0);
            Cleaner_Robot cleaner_Robot = new Cleaner_Robot("Temizlik Görevlisi Robot", 55, 8);
            restourant.AddRobot(server_Robot);
            restourant.AddRobot(chef_Robot);
            restourant.AddRobot(cleaner_Robot);
            restourant.StartService();
        }
    }
}
