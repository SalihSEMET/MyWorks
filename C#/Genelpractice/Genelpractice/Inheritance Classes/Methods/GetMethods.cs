using Genelpractice.Inheritance_Classes.Subclasses;

namespace Genelpractice.Inheritance_Classes.Methods;

public class GetMethods
{
    internal static Hause HauseAddInfoGet()
    {
        SeenMethods.StandartSeen();
        Console.WriteLine("Ev Ekleme Ekranı \n");
        Console.WriteLine("Apartman İçin(A)\nMüstakil Ev İçin(M)\nVilla İçin(V)\n|Lütfen Bir Seçim Yapınız|:");
        ConsoleKey consoleKey = Console.ReadKey().Key;
        switch (consoleKey)
        {
            case ConsoleKey.A:
                SeenMethods.StandartSeen();
                ApartmenBuilding apartmenBuilding = new ApartmenBuilding();
                Console.Write("Oda Sayısı");
                apartmenBuilding.roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Renk:");
                apartmenBuilding.colour = Console.ReadLine();
                Console.Write("Metrekare:");
                apartmenBuilding.squareMeters = double.Parse(Console.ReadLine());
                Console.Write("Kat Sayısı:");
                apartmenBuilding.flourNumber = int.Parse(Console.ReadLine());
                Console.Write("Asansör Var mı(Evet/Hayır):");
                apartmenBuilding.hasElevator = Console.ReadLine().ToLower() == "evet" ? true : false;
                return apartmenBuilding;
            case ConsoleKey.M:
                SeenMethods.StandartSeen();
                DetachedHouse detachedHouse = new DetachedHouse();
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
                SeenMethods.StandartSeen();
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
                SeenMethods.FailedSeen("Hatalı Seçim...");
                HauseAddInfoGet();
                break;
        }
        return default;
    }

    internal static void addHause(ref Hause[] hauses, Hause hause)
    {
        Array.Resize(ref hauses,hauses.Length + 1);
        hauses[hauses.Length - 1] = hause;
    }

    internal static void ListHouses(ref Hause[] hauses)
    {
        foreach (var item in hauses)
        {
            Console.WriteLine(new string('-',50));
            Console.WriteLine();

            item.ShowInfo();

            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
        }
        Console.WriteLine();
        Console.WriteLine("Menüye Dönmek İçin Herhangi Bir Tuşa Basınız...");
        Console.Read();
    }

    internal static ConsoleKey Menu(ref Hause[] hauses , Hause hause)
    {
        SeenMethods.StandartSeen();
        Console.WriteLine("|     Emlak Yönetim Uygulamasına Hoşgeldiniz     |");
        Console.WriteLine(new string('-', 50));

        Console.Write("Ev Ekle(E)\nEv Listele(L)\nÇıkış(Q)\n|Seçiminizi Giriniz|:");
        ConsoleKey consoleKey = Console.ReadKey().Key;
        switch (consoleKey)
        {
            case ConsoleKey.E:
                addHause();
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
}