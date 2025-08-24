using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ögrenme_Amaçlı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kapsülleme:Property(Özellik) ler aracılıgyla class içerisinde
            //orjinal field ı dışarıdan erişilmesini engelleyerek korumaya alarak
            //Field içerisine ilğili veriyi kontrollü bir şekilde property ler aracılıgıyla içerisine atamak.


            //Property(Özellik): Methotlar ve Fieldların birleşimi/karışımı. Yani
            //Propertyler Hem Methodlar Gibi Hemde Fieldlar gibi kullanılabiliyor.

            Vatandaş vatandaş = new Vatandaş();
            vatandaş.TCNO = ""; 
        }
    }
}
