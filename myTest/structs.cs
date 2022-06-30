using System;
using System.IO;

namespace Hello_world
{
    struct Juego
    {
        internal string name;
        internal string developer;

        internal Juego(string name, string dev)
        {
            this.name = name;
            this.developer = dev;
        }
    }

    class Structs
    {
        internal void Stru()
        {
            Juego pokemon = new Juego("Pokemon", "Nintendo");
            Console.WriteLine(pokemon.name);
        }
    }
}
