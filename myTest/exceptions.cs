namespace Hello_world
{
    class Exceptions
    {
        public static void exc()
        {
            Console.WriteLine("Enter a number");
            string value = Console.ReadLine();

            try
            {
                int num = int.Parse(value);
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only numbers.");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Entered number is too big or too small.");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("You haven't entered a value.");
            }
            finally
            {
                Console.WriteLine("This will be displayed no matter what.");
            }
        }
    }
}
        