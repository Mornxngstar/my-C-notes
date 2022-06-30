using System;

namespace Hello_world
{
    class Rndm
    {
        public void ra()
        {
            Random num = new Random();
            int due;

            for(int i = 0; i < 10; i++)
            {
                due =  num.Next(1, 7);
                Console.WriteLine(due);
            }

        }
    }
}