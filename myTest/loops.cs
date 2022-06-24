namespace Hello_world
{
    class Loops
    {
        public static void loop()
        {
            //for loop
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //for each loop
            string[] names = { "Jojo", "Dani", "Diego" };

            foreach (string i in names)
            {
                Console.WriteLine("Buena po {0} qlo", i);
            }

            //while loop
            bool j = true;
            while (j)
            {
                Console.WriteLine("Hi");
                j = !j;
            }

            //do while loop
            int x = 0;
            do
            {
                Console.WriteLine("Bye");
                x++;
            } while (x < 5);
        }
    }
}