using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_İlkeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OOP İlkeleri
            //1) Kalıtım(Inheritance)
            //2) Encapsulation(Kapsülleme)
            //3) Polymorphsym(Çok Biçimlilik)
            //4) Abstraction(Soyutlama)

            #region Inheritance -- Kalıtım

            //Inheritance
            //Üst Classlar dan Alt Class lara Özelliklerin Aktarılması Ve Tiplerin Tek Bir Çatı Altında Toplanması Durumudur.
            //C# da Çoklu Kalıtım Dogrudan Mümkün Değildir ama Dolaylı Yoldan Yapılabilir.


            //House house = new House();

            //detachedHouse detachedHouse = new detachedHouse();

            //apartmentBuilding apartmentBuilding = new apartmentBuilding();

            //string[] citys = new string[5];

            //citys[0] = "Ankara";
            //citys[1] = "İstanBul";


            //House[] houses = new House[5];

            //houses[0] = house;
            //houses[1] = detachedHouse;
            //houses[2] = apartmentBuilding;


            #endregion

            House[] houses = new House[0];
            while (true)
            {
                ConsoleKey consoleKey = Menu();
                switch (consoleKey)
                {
                    case ConsoleKey.E:
                        addHouse(ref houses, HouseAddInfoGet());
                        break;
                    case ConsoleKey.L:
                        ListHouses(ref houses);
                        break;
                    case ConsoleKey.Q:
                        SuccessSeen(2500, "Çıkış Yapılıyor...");
                        SuccessSeen("Çıkış Yapıldı");
                        return;
                }
            }
        }

        static ConsoleKey Menu()
        {
            House house = new House();
            StandartSeen();
            Console.WriteLine(new string('-',50));
            Console.WriteLine("|     Emlak Yönetim Uygulamasına Hoşgeldiniz     |");
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Ev Ekle(E)\nEv Listele(L)\nÇıkış(Q)\n|Seçiminizi Giriniz|:");
            ConsoleKey consoleKey = Console.ReadKey().Key;
            switch (consoleKey)
            {
                case ConsoleKey.E:
                    break;
                case ConsoleKey.L:
                case ConsoleKey.Q:
                    return consoleKey;
                default:
                    Menu();
                    break;
            }
            return ConsoleKey.Q;
        }

        static void StandartSeen()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static void SuccessSeen(string message = "")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            if (!string.IsNullOrEmpty(message))
                Console.WriteLine(message);
            Thread.Sleep(1500);
        }
        static void SuccessSeen(int millisecound,string message = "")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            if (!string.IsNullOrEmpty(message))
                Console.WriteLine(message);
            Thread.Sleep(millisecound);
        }
        static void FailedSeen(string message = "")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            if (!string.IsNullOrEmpty(message))
                Console.WriteLine(message);
            Thread.Sleep(1500);
        }
        static void FailedSeen(int millisecound, string message = "")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            if(!string.IsNullOrEmpty(message))
                Console.WriteLine(message);
            Thread.Sleep(millisecound);
        }
        static House HouseAddInfoGet()
        {
            StandartSeen();
            Console.WriteLine("Ev Ekleme Ekranı\n");
            Console.WriteLine("Apartman İçin(A)\nMüstakil Ev İçin(M)\nVilla İçin(V)\n|Lütfen Bie Seçim Yapınız|:");
            ConsoleKey consoleKey = Console.ReadKey().Key;
            switch (consoleKey) 
            {
                case ConsoleKey.A:
                    StandartSeen();
                    apartmentBuilding apartmentBuilding = new apartmentBuilding();
                    Console.WriteLine("Oda Sayısı:");
                    apartmentBuilding.roomNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Renk:");
                    apartmentBuilding.colour = Console.ReadLine();
                    Console.WriteLine("Metrekare:");
                    apartmentBuilding.squareMeters = double.Parse(Console.ReadLine());
                    Console.WriteLine("Kat Sayısı:");
                    apartmentBuilding.flourNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Asansör Var mı(Evet/Hayır):");
                    apartmentBuilding.hasElevator = Console.ReadLine().ToLower() == "evet" ? true : false;
                    return apartmentBuilding;
                case ConsoleKey.M:
                    StandartSeen();
                    detachedHouse detachedHouse = new detachedHouse();
                    Console.WriteLine("Oda Sayısı:");
                    detachedHouse.roomNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Renk:");
                    detachedHouse.colour = Console.ReadLine();
                    Console.WriteLine("Metrekare:");
                    detachedHouse.squareMeters = double.Parse(Console.ReadLine());
                    Console.WriteLine("Garaj Var mı(Evet/Hayır):");
                    detachedHouse.hasGarage = Console.ReadLine().ToLower() == "evet" ? true: false;
                    Console.WriteLine("Bahçe Metrekaresi:");
                    detachedHouse.gardenSquareMeters = double.Parse(Console.ReadLine());
                    return detachedHouse;
                case ConsoleKey.V:
                    StandartSeen();
                    Villa villa = new Villa();
                    Console.WriteLine("Oda Sayısı:");
                    villa.roomNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Renk:");
                    villa.colour = Console.ReadLine();
                    Console.WriteLine("Metrekare:");
                    villa.squareMeters = double.Parse(Console.ReadLine());
                    Console.WriteLine("Havuz Var mı(Evet/Hayır):");
                    villa.hasPool = Console.ReadLine().ToLower() == "evet" ? true : false;
                    Console.WriteLine("Garaj Var mı(Evet/Hayır):");
                    villa.hasGarage = Console.ReadLine().ToLower() == "evet" ? true : false;
                    return villa;
                default:
                    FailedSeen("Hatalı Seçim...");
                    HouseAddInfoGet();
                    break;
            }
            return default;
        }
        static void addHouse(ref House[] houses, House house)
        {
            Array.Resize(ref houses, houses.Length + 1);
            houses[houses.Length - 1] = house;
        }
        static void ListHouses(ref House[] houses)
        {
            foreach (var item in houses)
            {
                Console.WriteLine(new string('-',50));
                Console.WriteLine();

                item.ShowInfo();

                Console.WriteLine();
                Console.WriteLine(new string('-', 50));
            }
            Console.WriteLine();
            Console.WriteLine("Menüye Dönmek İçin Herhangi Bir Tuşa Basınız..."); Console.Read();
        }

    }
}
