namespace Hello_world
{
    class Casting
    {
        public static void cast()
        {
            
            //explicit conversion
            int myInt;
            double myDouble = 12.554;

            myInt = (int)myDouble;   
            Console.WriteLine(myInt);

            //implicit conversion

            int num = 123124;
            long numg = num;  
            Console.WriteLine(numg);

            //type conversion

            myDouble = 12.42;
            string myString = myDouble.ToString();

            //parsing

            string myText = "15";
            int myNum = Int32.Parse(myText);

            //TryParse

            string numAsString = "128";
            int numAsInt;

            bool check = int.TryParse(numAsString, out numAsInt);

            if(check)
            {
                Console.WriteLine("Number has been parsed succesfully: {0}", numAsInt);
            }
            else
            {
                Console.WriteLine("Number has not been parsed");
            }

        }
    }
}