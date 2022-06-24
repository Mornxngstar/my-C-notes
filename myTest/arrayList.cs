using System;
using System.Collections;
namespace Hello_world
{
    class ArrayList
    {
        public void ArrayListMain()
        {
            ArrayList miArrayList = new ArrayList();

            miArrayList.Add(12);
            miArrayList.Add("Hola");
            miArrayList.Add(true);
            miArrayList.Add(12.5);
            miArrayList.Add("Adios");

            miArrayList.Remove(true);   //Removes the value that's given

            miArrayList.RemoveAt(3);  //Removes a value according to the index given

           // Console.WriteLine(miArrayList.Count);

            double suma = 0;

            foreach (object obj in miArrayList)
            {
                if (obj is int)
                {
                    suma += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    suma += Convert.ToDouble(obj);
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            miArrayList.Add(new Numero {n = 4});
            Console.WriteLine(suma);
            Console.Read();
        }
    }
    class Numero
    {
        public int n { get; set; }

        public override string ToString()
        {
            return n.ToString();
        }
    }
}