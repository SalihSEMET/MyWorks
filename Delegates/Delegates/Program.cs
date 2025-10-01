using System.Globalization;

namespace Delegates
{
    delegate int MathDelegate(int number1, int number2);
    delegate void LoggerDelegate(string message);
    delegate bool numbercontrolDelegate(int number);
    class Program()
    {
        
        static void Main()
        {
            Methots methots = new Methots();
            LoggerDelegate logger = methots.ConsoleLogger;
            MathDelegate mathDelegate = methots.Add;
            Console.WriteLine($"{mathDelegate.Invoke(5,3)}");
            mathDelegate += methots.Subtract;
            Console.WriteLine($"{mathDelegate.Invoke(5,3)}");
            mathDelegate += methots.Multiply;
            Console.WriteLine($"{mathDelegate.Invoke(5,3)}");
            mathDelegate += methots.Divide;
            Console.WriteLine($"{mathDelegate.Invoke(5,3)}");
            logger("Selamun Aleyküm Dünya");
            logger = methots.FileLogger;
            logger("Selamun Aleyküm Dünya");
            methots.Check(5,methots.isEvenNumber);
            methots.Check(18,methots.isPositive);
        }
    }   
    class Methots
    {
        internal  int  Add(int number1, int number2) => number1 + number2;
        internal  int  Subtract(int number1, int number2) => number1 - number2;
        internal  int  Multiply(int number1, int number2) => number1 * number2;
        internal  int  Divide(int number1, int number2) => number1 / number2;
        internal  void ConsoleLogger(string message) => Console.WriteLine(message);
        internal  void FileLogger(string message) => File.AppendAllText("log.txt",message);
        internal  bool isEvenNumber(int number) => number % 2 == 0;
        internal  bool isPositive(int number) => number > 0;

        internal  void Check(int number, numbercontrolDelegate numbercontrol)
        {
            if (numbercontrol(number))
            {
                Console.WriteLine($"{number} Sayısı Koşulu Saglıyor");
            }
            else
            {
                Console.WriteLine($"{number} Sayısı Koşulu Saglamıyor");
            }
        }
    }
}

