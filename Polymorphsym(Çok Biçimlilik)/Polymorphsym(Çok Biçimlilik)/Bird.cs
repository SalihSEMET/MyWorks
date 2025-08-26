using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsym_Çok_Biçimlilik_
{
    class Bird : Animal
    {
        SoundPlayer SoundPlayer = new SoundPlayer("C:\\Users\\semet\\OneDrive\\Belgeler\\Polymorphsym(Çok Biçimlilik)\\Polymorphsym(Çok Biçimlilik)\\Sounds Effect\\bird.wav");
        internal override void playSound()
        {
            Console.WriteLine("Bird Cik Cik");
            SoundPlayer.Play();
        }
    }
}
