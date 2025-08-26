using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsym_Çok_Biçimlilik_
{
    abstract class Animal
    {
        public int Age { get; set; }

        //Abstrack:Soyut
        //Abstract Methodlar Gövdesi Olmayan ve Mutlaka Abstrack Metohdlar Abstract class lar İçinde Kullanılır 
        //Abstract Bir Method Tanımlamak İstorsak Mutlaka class ında Abstract olması Lazım
        //Kalıtım Alan class içerisinde mecbur gövdesi oluşturulmaya zorlanan methodlar
        internal abstract void playSound();
    }
}
