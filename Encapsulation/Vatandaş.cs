using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ögrenme_Amaçlı
{
    internal class Vatandaş
    {
        string tcNo = "";
        internal string TCNO 
        {
            get
            {
                return tcNo;
            }
            set
            {
                if(value != "" && value.Length == 11 && value.StartsWith("0"))
                {
                    tcNo = value;
                }
            }
        }


    }
}
