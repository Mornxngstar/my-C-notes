namespace Hello_world
{
    class Operators
    {
        public static void op()
        {
            int num = 0;
            int num1 = 5;

            int num2 = -num1;   // num2 = -5

            Console.WriteLine(-num1);

            // Adition
            num++;        // num = 1


            //Sustraction
            num--;        // num = 0



            bool x = true;

            Console.WriteLine(!x);           // x = false


            num = 0;        
            Console.WriteLine(num++);      // Console will print 0
            Console.WriteLine(num);        // Console will print 1

            num = 0;
            Console.WriteLine(++num);      // Console will print 1

            bool esMayor = 5 > 3;
            bool esMenor = 5 < 3;

            bool both = esMayor && esMenor;
            bool one = esMayor || esMenor;

        }
    }
}