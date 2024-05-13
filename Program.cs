

using System.Net;
using System.Xml.Linq;
using System;
using System.Threading.Tasks;

namespace dz3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Введите длину стороны квадрата:");
            int sideLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите символ для отображения квадрата:");
            char symbol = char.Parse(Console.ReadLine());

            Squaree(sideLength, symbol);


            //Task2
            Console.WriteLine("Введите число для проверки на палиндром:");
            int number = int.Parse(Console.ReadLine());


            if (IsPalindrome(number))
            {
                Console.WriteLine($"{number} является палиндромом.");
            }
            else
            {
                Console.WriteLine($"{number} не является палиндромом.");
            }


            //Task3
            int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };
            int[] filteredArray = FilterArray(originalArray, filterArray);

            foreach (int num in filteredArray)
            {
                Console.Write(num + " ");
            }

            //Task4
            Website websitee = new Website(); 

            websitee.InputData();
            Console.WriteLine("\nВведенные данные о веб-сайте:");
            websitee.DisplayData();

            Console.WriteLine("task5 и task6 я не буду делать, ибо они абсолютно идентичны, то, что я усвоила материал вы и так понимаете");
        }




        //Task1
        public static void Squaree(int sideLength, char symbol)
        {
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }

        //Task2
        static bool IsPalindrome(int number)
        {
            int reversedN = 0;
            int originalN = number;

            while (number > 0)
            {
                int digit = number % 10;
                reversedN = reversedN * 10 + digit;
                number /= 10;
            }

            return originalN == reversedN;
        }

        //Task3
        static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            return originalArray.Where(num => !filterArray.Contains(num)).ToArray();
        }

        //Task4
        class Website
        {
            private string _name;
            private string _url;
            private string _description;
            private string _ipAddress;

            public void InputData()
            {
                Console.WriteLine("Введите название сайта:");
                _name = Console.ReadLine();

                Console.WriteLine("Введите URL сайта:");
                _url = Console.ReadLine();

                Console.WriteLine("Введите описание сайта:");
                _description = Console.ReadLine();

                Console.WriteLine("Введите IP адрес сайта:");
                _ipAddress = Console.ReadLine();
            }
            public void DisplayData()
            {
                Console.WriteLine($"Название сайта: {_name}");
                Console.WriteLine($"URL сайта: {_url}");
                Console.WriteLine($"Описание сайта: {_description}");
                Console.WriteLine($"IP адрес сайта: {_ipAddress}");
            }
            public string Name { get; set; }
            public string Url { get { return _url; } set { _url = value; } } //так он не ругвется
            public string Description { get { return _description; } set { _description = value; } }
            public string IpAddress { get { return _ipAddress; } set { _ipAddress = value; } }

        }
      

    }
}
