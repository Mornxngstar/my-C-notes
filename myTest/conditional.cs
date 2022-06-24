namespace Hello_world
{
    class Conditions
    {
        public static void conditional()
        {
            int temperatura = -5;
            string estadoDelAgua = temperatura < 0 ? "Solido" :  temperatura >= 100 ? "Gaseoso" : "Liquido";
        }
    }
}