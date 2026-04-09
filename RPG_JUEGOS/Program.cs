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
            int vidaJugador;
            int danoJugador;

            Console.WriteLine("Ingrese el Nombre de su personaje");
            nombreJugador = Console.ReadLine();

            Console.WriteLine("Ingrese la vida de su personaje:");
            vidaJugador = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el daño de su personaje:");
            danoJugador = int.Parse(Console.ReadLine());

            //ENEMIGO
            string nombreEnemigo = "Goblin";
            int vidaEnemigo = 80;
            int danoEnemigo = 15;

            //ITEM
            int pociones = 2;

            Console.WriteLine("Comienza la batalla contra el " + nombreEnemigo);

            // TURNOS
            while(vidaJugador > 0 && vidaEnemigo > 0)
            {
                Console.WriteLine("TURNO");
                Console.WriteLine(nombreJugador + " Vida: " + vidaJugador);
                Console.WriteLine(nombreEnemigo + " Vida: " + vidaEnemigo);
                Console.WriteLine("Pociones: " + pociones);

                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Usar poción");
                Console.Write("Elige una opción: ");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    vidaEnemigo -= danoJugador;
                    Console.WriteLine("Atacaste e hiciste " + danoJugador + " de daño.");
                }

                else if (opcion == 2 && pociones > 0)
                {
                    vidaJugador += 20;
                    pociones--;
                    Console.WriteLine("Usaste una poción.");
                }

                else
                {
                    Console.WriteLine("Opción inválida.");
                }

                if (vidaEnemigo > 0)
                {
                    vidaJugador -= danoEnemigo;
                    Console.WriteLine("El enemigo te atacó.");
                }
            }

            if (vidaJugador > 0)
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Perdiste");
            }
            Console.ReadLine();



        }
    }
}
