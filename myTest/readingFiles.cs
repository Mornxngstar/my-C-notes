namespace Hello_world
{
    class readAFile
    {
        public void Reading()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\josus\OneDrive\Documentos\Programming\c#\Test.txt");
            Console.WriteLine(text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\josus\OneDrive\Documentos\Programming\c#\Test.txt");

            foreach(string i in lines)
            {
                Console.WriteLine("\t" + i);
            }
            Console.Read();
        }
    }
}