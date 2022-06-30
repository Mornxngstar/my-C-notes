using System;
using System.IO;

namespace Hello_world
{
    class WriteAFile
    {
        public void Writing()
        {
            //Primer metodo
            string[] lines = {"First line", "Second line", "Third line"};
            File.WriteAllLines(@"C:\Users\josus\OneDrive\Documentos\Programming\c#\Test.txt", lines);

            //Segundo metodo
            Console.WriteLine("Enter the file's name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the content");
            string text = Console.ReadLine();

            File.WriteAllText(@"C:\Users\josus\OneDrive\Documentos\Programming\c#\" + name + ".txt", text);

            //Tercer metodo
            string[] lines2 = {"First line", "Second line", "Third line"};
            using(StreamWriter file = new StreamWriter(@"C:\Users\josus\OneDrive\Documentos\Programming\c#\anotherText.txt"))
            {
                foreach(string line in lines2)
                {
                    if(line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            //Agrega texto al archivo sin sobreescribir 
            using (StreamWriter file = new StreamWriter(@"C:\Users\josus\OneDrive\Documentos\Programming\c#\anotherText.txt", true))
            {
                file.WriteLine("Aditional text");
            }
            Console.Read();

        }
    }
}