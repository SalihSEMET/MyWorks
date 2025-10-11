using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsym_Çok_Biçimlilik_
{
    class Dog : Animal
    {
        SoundPlayer SoundPlayer = new SoundPlayer("C:\\Users\\semet\\OneDrive\\Belgeler\\Polymorphsym(Çok Biçimlilik)\\Polymorphsym(Çok Biçimlilik)\\Sounds Effect\\dog.wav");
        internal override void playSound()
        {
            Console.WriteLine("Dog Hav");
            SoundPlayer.Play();
        }
    }
}
