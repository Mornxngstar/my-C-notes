namespace Hello_world
{    
    class SwitchCondition
    {
        public static void switchConditional()
        {
            int cars = 2;

            switch (cars)
            {
                case 0:
                    Console.WriteLine("You pay $15");
                    break;
                
                case 1:
                    Console.WriteLine("You pay $30");
                    break;
                
                case 2:
                    Console.WriteLine("You pay $45");
                        break;
                
                default:
                    Console.WriteLine("You pay $15 per car");
                        break;
            }
        }
    }
}
   