using System;

namespace Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            dotnet new console -o myTest
            dotnet restore
            dotnet run
            */

            int x;
            x = 14;

            sbyte sb = 120;
            short sh = 12713;
            int y = 1211237;
            long loo = 1214215123;

            float floo = 3.99f;
            double height = 12.125;
            decimal decc = 35.66575m;

            bool alive = true;

            char symbol = '@';
            string name = "Josh";

            Console.WriteLine(x + y);

            string username = symbol + name;
            Console.WriteLine(username);

            const double pi = 3.14159;
            int a = Convert.ToInt32(pi);
            double b = Convert.ToDouble(a);
            string c = Convert.ToString(a);

            Console.WriteLine(a.GetType());
            Console.Write("Algo");
            Console.Read();         //devuelve el input en formato ASCII
            Console.ReadLine();
            Console.ReadKey();
            

            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine();
            Console.WriteLine(text);
            Console.WriteLine("Enter the character you're searching for:");
            char wantedText = Console.ReadLine()[0];

            int i = text.IndexOf(wantedText);

            Console.WriteLine("Character was found in index {0}", i);
            WriteSomething();
            
        }

        public static void WriteSomething()
        {
            Console.WriteLine("Good Morning.");
        }

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
