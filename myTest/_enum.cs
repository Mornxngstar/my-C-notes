namespace Hello_world
{
     enum Days {Lu, Ma, Mi, Ju=4, Vi, Sa, Do };

    class Enum
    {
        public void En()
        {
            Days lunes = Days.Lu;
            Days jueves = Days.Ju;

            Console.WriteLine(lunes);
            Console.WriteLine(jueves);
            Console.WriteLine((int)lunes);
            Console.WriteLine((int)jueves);

        }
    }
}