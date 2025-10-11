using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_İLkeleri_Devam
{
    class citizen
    {
        string tcNo;
        internal string TCNO 
        {
            get
            {
                return tcNo;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    if(value.Substring(0,1) != "0")
                    {
                        if(value.Length == 11)
                        {
                            if (Control(value))
                            {
                                if (Control2(value)) 
                                {
                                    tcNo = value;
                                }
                                else
                                {
                                    Console.WriteLine("Tc Geçersiz");
                                }
                            }
                            else
                            {
                                Console.WriteLine("İlk 10 Hanenin Toplamının Modu Son Haneyi Vermeli");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Tc 11 Haneden Oluşmalıdır");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tc No Sıfır İle Başlayamaz");
                    }
                }
                else
                {
                    Console.WriteLine("Tc No Boş Yada Eksik");
                }
            }
        }
        bool Control(string tcno)
        {
            int total = 0;
            for (int i = 0; i < tcno.Length - 1; i++)
            {
                total += tcno[i] - '0';
            }

            int lastDigit = tcno[tcno.Length - 1] - '0';
            return (total % 10) == lastDigit;
        }
        bool Control2(string tcno)
        {
            int oddnumbertotal = 0;
            int evennumbertotal = 0;
            for (int i = 0; i < 9; i+= 2)
            {
                oddnumbertotal += tcno[i];
            }
            for (int i = 1; i < 8; i+= 2)
            {
                evennumbertotal += tcno[i];
            }
            int resoult = oddnumbertotal * 7 - evennumbertotal;
            int tenDigit = tcno[9];
            return (resoult % 10) == tenDigit;
        }

    }
}
