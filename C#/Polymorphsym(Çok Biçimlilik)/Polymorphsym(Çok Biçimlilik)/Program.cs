using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsym_Çok_Biçimlilik_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Dog dog = new Dog();
            Cat cat = new Cat();
            Console.WriteLine("Hangi Hayvanı Seçiceksiniz\n1)Kuş\n2)Köpek\n3)Kedi");
            Console.Write("Seçiminiz Nedir:");
            int choose = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choose)
            {
                case 1:
                    bird.playSound();
                    break;
                case 2:
                    dog.playSound();
                    break;
                case 3:
                    cat.playSound();
                    break;
            }
            Console.ReadLine();
        }
    }
}
