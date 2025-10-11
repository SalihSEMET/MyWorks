using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // Base Class - Ana Class(Sınıf)
    abstract class Restourant_Robot
    {
        public string robotName { get; set; }

        public Smart_Robot_State Smart_Robot_State { get; set; }

        public Restourant_Robot(string robotname,int battary,int workhour)
        {
            robotName = robotname;
            Smart_Robot_State = new Smart_Robot_State(battary,workhour);
        }
        //Abstract Soyut 
        //Abstract Methodlar Abstract Class Lar da Kullanılır
        public abstract void StartWork(); //Polymorphsym(Çok Biçimlilik)
    }
}
