namespace Hello_world
{
    public interface ICar
    {
        string Model { get; set; }
        string Color { get; set; }

        void Drive();
    }

    class Car : ICar  //<---------------------------- Check the error message
    {

    }

    class Interfaces
    {
        public void Inter()
        {
            
        }
    }
}