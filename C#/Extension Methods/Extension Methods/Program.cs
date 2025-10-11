namespace Extension_Methods
{
    class Program
    {
        static void Main()
        {
            //Sistemde Önceden Tanımlı Olan Herhangi bir tipe özğü method Yazmak.
            double salary = 45000.67;
            int number = 100;
            Console.WriteLine(salary.Calculatetwentypercent());
            Console.WriteLine(number.CalculateMultiplybysfive());
            List<string> names = new List<string>();
            names.Add("Aydın"); names.Add("Yavuz"); names.Add("Salih"); names.Add("Kerem");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}. İsim Şuanda:{names[i]}");
            }
            names.Mixlist();
            Console.WriteLine("---------------------------------------------------");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}. İsim Karışmış Halinde:{names[i]}");
            }
        }
    }
    static class DoubleExtantions
    {
        public static double Calculatetwentypercent(this double number)
        {
            return number * 0.2;
        }
    }

    static class IntExtantions
    {
        public static int CalculateMultiplybysfive(this int number)
        {
            return number * 5;
        }
    }
}