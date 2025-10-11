using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_İLkeleri_Devam
{
    class DebitCard
    {
		private string  cardNumber;

		public string  CardNumber
		{
			get 
			{
				return cardNumber; 
			}
			set 
			{
                if (IsValidLuhn(value))
                {
                    cardNumber = value;
                }
                else
                {
                    Console.WriteLine("Kart Numarası Geçersiz");
                }
			}
		}

        internal decimal Balancee { get { return balance; } }

        //Read Only Property : Sadece Dewgeri Okunabilen İçindeki Deger Degiştirilemeyen Property türü Get i Var Set i Yok
		private decimal balance;
		public decimal Balance
		{
			get 
			{ 
				return balance; 
			}
		}
        public static bool IsValidLuhn(string number)
        {
            int sum = 0;
            bool doubleDigit = false;

            // Sağdan sola doğru ilerleyerek her basamağı kontrol et
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (!char.IsDigit(number[i]))
                    return false; // Sayı olmayan karakter varsa geçersiz

                int digit = number[i] - '0';

                if (doubleDigit)
                {
                    digit *= 2;
                    if (digit > 9)
                        digit -= 9;
                }

                sum += digit;
                doubleDigit = !doubleDigit;
            }

            return sum % 10 == 0;
        }
        internal void withdrawal(decimal count)
        {
            if(count <= 0)
            {
                Console.WriteLine("Geçersiz Miktar");
            }
            else if(count > balance)
            {
                Console.WriteLine("Yetersiz Bakiye");
            }
            else
            {
                balance -= count;
            }
        }
        internal void depositMoney(decimal count)
        {
            if(count <=)
            {
                Console.WriteLine("Geçersiz Miktar");
            }
            else
            {
                balance += count;
                Console.WriteLine($"{count} Kadar Yatırıldı Yeni Bakiye{balance}");
            }
        }
    }
}
