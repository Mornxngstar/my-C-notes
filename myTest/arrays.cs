namespace Hello_world
{
    class Arrays
    {
        public void arr()
        {
            //Primera forma de inicializar un array
            int[] calificaciones = new int[5];
            calificaciones[0] = 10;
            calificaciones[1] = 7;
            calificaciones[2] = 9;
            calificaciones[3] = 3;
            calificaciones[2] = 7;

            //Segunda forma de inicializar un array
            int[] edades = { 16, 17, 18, 17 };

            //Tercera forma de inicializar un array
            int[] faltas = new int[] { 2, 3, 6, 1, 8, 5 };

            Console.WriteLine(faltas.Length);
            Console.Read();
        }
    }
}