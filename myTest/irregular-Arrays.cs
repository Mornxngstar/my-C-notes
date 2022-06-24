namespace Hello_world
{
    class IrregularArray
    {
        public void Irregular()
        {
            int[][] irregular = new int[3][];

            irregular[0] = new int[5];
            irregular[1] = new int[3] { 4, 7, 19 };
            irregular[2] = new int[2] { 3, 8 };

            irregular[0] = new int[] { 2, 3, 8, 9, 5 };

            int[][] irregular2 = new int[][]
            {
                new int[5] { 2, 3, 8, 9, 5 },
                new int[3] { 4, 7, 19 },
                new int[2] { 3, 8 }
            };

            // Console.WriteLine(irregular2[0][2]);    //Prints 8

            for (int i = 0; i < irregular2.Length; i++)
            {
                for (int j = 0; j < irregular2[i].Length; j++)
                {
                    Console.WriteLine(irregular2[i][j]);
                }
            }
        }
    }
}