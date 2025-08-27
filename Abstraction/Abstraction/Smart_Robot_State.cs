using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Smart_Robot_State
    {
        int battary;
        int workhour;
        public int Battary 
        {
            get
            {
                return battary;
            }
            set
            {
                //Ternary Operatörü
                battary = value < 0 ? 0 : (value > 100 ? 100 : value);
            }
        }
        public int WorkHour 
        {
            get 
            {
                return workhour;
            }
            set
            {
                workhour = value < 0 ? 0 : value;
            }
        }
        public Smart_Robot_State(int battary,int workhour)
        {
            Battary = battary;
            WorkHour = workhour;
        }
    }
}
