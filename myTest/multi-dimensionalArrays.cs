namespace Hello_world
{
    class Multidimensional
    {
        public void multi()
        {
            //Array/Matriz 2D
            string[,] array2D = new string[,]
            {
                {"A","B","C"},
                {"D","E","F"},
                {"G","H","I"}
            };

            Console.WriteLine(array2D[1,2]+ " - " + array2D.Rank);

            //Array/Matriz 23D
            string[,,] array3D = new string[,,]
            {
                {
                    {"A","B","C"},
                    {"D","E","F"},
                    {"G","H","I"}
                },
                {
                    {"J","K","L"},
                    {"M","N","O"},
                    {"P","Q","R"}
                },
                {
                    {"S","T","U"},
                    {"V","W","X"},
                    {"Y","Z","*"}
                }
            };

            Console.WriteLine(array3D[1,2,0] + " -  " + array3D.Rank);
        }
    }
}