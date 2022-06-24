using System;

namespace OOP
{
    class Human
    {
        private string name;
        private int age;

        public Human()
        {
            Console.WriteLine("I have no data.");
        }

        public Human(string name)
        {
            this.name = name;
        }

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Introduce()
        {
            Console.WriteLine("My name is " + name);
        }
    }
}