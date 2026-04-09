using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_JUEGOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PERSONAJE
            string nombreJugador;
            int vidaJugador = 100;
            int danoJugador = 20;

            Console.WriteLine("Ingrese el Nombre de su personaje");
            nombreJugador = Console.ReadLine();

            //ENEMIGO
            string nombreEnemigo = "Goblin";
            int vidaEnemigo = 80;
            int danoEnemigo = 15;

            //ITEM
            int pociones = 2;

            Console.WriteLine("Comiendza la batalla contra el " + nombreJugador);





        }
    }
}
