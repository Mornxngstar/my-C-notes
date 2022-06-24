using System;

namespace OOP
{
    class Caja
    {
        private int length, height;

        //First way to make a property
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                Length = value;
            }
        }

        /*
        
        This is a shorter way to do the same
        
            public int Length
            {
                get => length;
                set => length = value;
            }
        
        */

        //Second way to do it
        public int Width { get; set; }   //With this method you don't need to declarate any variables

        //With the second method you could also:
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0) value = -value;  //throw new Exception("The value must be higher than 0");
                height = value;
            }
        }

        /*
        public int Volume 
        {
            get
            {
                return Height * Width * Length;
            }
        }
        */

        public int Volume
        {
            get => Height * Width * Length;
        }

        public Caja(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }

        public void ShowInfo()
        {
            Console.WriteLine("The length is {0}, the height is {1}, the width is {2}, therefore, the volume is {3}",
                Length, Height, Width, Volume);
        }
    }
}
