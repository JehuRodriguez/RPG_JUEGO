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
            // ===== PERSONAJE =====
            string nombreJugador;
            int vidaJugador;
            int danoJugador;

            Console.WriteLine("Ingrese el nombre de su personaje:");
            nombreJugador = Console.ReadLine();

            Console.WriteLine("Ingrese la vida de su personaje:");
            vidaJugador = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el daño de su personaje:");
            danoJugador = int.Parse(Console.ReadLine());


            // ===== ENEMIGOS =====
            string nombreEnemigo = "Goblin";
            int vidaEnemigo = 80;
            int danoEnemigo = 15;

            string nombreEnemigo2 = "Protoss";
            int vidaEnemigo2 = 90;
            int danoEnemigo2 = 18;

            string nombreEnemigo3 = "Terran";
            int vidaEnemigo3 = 100;
            int danoEnemigo3 = 20;


            // ===== ITEMS =====
            int pociones = 0;
            int comidas = 0;

            Console.WriteLine("\n¡Comienzan las batallas contra múltiples enemigos!\n");

            // 🟢 BATALLA 1 - GOBLIN
            // =========================
            Console.WriteLine("Batalla contra " + nombreEnemigo);

            while (vidaJugador > 0 && vidaEnemigo > 0)
            {
                Console.WriteLine("\n--- TURNO ---");
                Console.WriteLine(nombreJugador + " Vida: " + vidaJugador);
                Console.WriteLine(nombreEnemigo + " Vida: " + vidaEnemigo);

                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Usar item");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    vidaEnemigo -= danoJugador;
                    Console.WriteLine("Atacaste.");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("1. Poción (" + pociones + ")");
                    Console.WriteLine("2. Comida (" + comidas + ")");
                    int item = int.Parse(Console.ReadLine());

                    if (item == 1 && pociones > 0)
                    {
                        vidaJugador += 20;
                        pociones--;
                        Console.WriteLine("Usaste poción (+20)");
                    }
                    else if (item == 2 && comidas > 0)
                    {
                        vidaJugador += 40;
                        comidas--;
                        Console.WriteLine("Usaste comida (+40)");
                    }
                    else
                    {
                        Console.WriteLine("No tienes ese item.");
                    }
                }

                if (vidaEnemigo > 0)
                {
                    vidaJugador -= danoEnemigo;
                    Console.WriteLine("El enemigo atacó.");
                }
            }

            // 🔥 DROP GOBLIN
            if (vidaEnemigo <= 0)
            {
                Console.WriteLine("El Goblin dejó una poción.");
                pociones++;
            }

            // 🟣 BATALLA 2 - PROTOSS
            // =========================
            if (vidaJugador > 0)
            {
                Console.WriteLine("\nBatalla contra " + nombreEnemigo2);

                while (vidaJugador > 0 && vidaEnemigo2 > 0)
                {
                    Console.WriteLine("\n--- TURNO ---");
                    Console.WriteLine(nombreJugador + " Vida: " + vidaJugador);
                    Console.WriteLine(nombreEnemigo2 + " Vida: " + vidaEnemigo2);

                    Console.WriteLine("1. Atacar");
                    Console.WriteLine("2. Usar item");
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1)
                    {
                        vidaEnemigo2 -= danoJugador;
                        Console.WriteLine("Atacaste.");
                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine("1. Poción (" + pociones + ")");
                        Console.WriteLine("2. Comida (" + comidas + ")");
                        int item = int.Parse(Console.ReadLine());

                        if (item == 1 && pociones > 0)
                        {
                            vidaJugador += 20;
                            pociones--;
                            Console.WriteLine("Usaste poción.");
                        }
                        else if (item == 2 && comidas > 0)
                        {
                            vidaJugador += 40;
                            comidas--;
                            Console.WriteLine("Usaste comida.");
                        }
                        else
                        {
                            Console.WriteLine("No tienes ese item.");
                        }
                    }

                    if (vidaEnemigo2 > 0)
                    {
                        vidaJugador -= danoEnemigo2;
                        Console.WriteLine("El enemigo atacó.");
                    }
                }

                // 🔥 DROP PROTOSS
                if (vidaEnemigo2 <= 0)
                {
                    Console.WriteLine("El Protoss dejó comida.");
                    comidas++;
                }

                // 🔴 BATALLA 3 - TERRAN
                // =========================
                if (vidaJugador > 0)
                {
                    Console.WriteLine("\nBatalla contra " + nombreEnemigo3);

                    while (vidaJugador > 0 && vidaEnemigo3 > 0)
                    {
                        Console.WriteLine("\n--- TURNO ---");
                        Console.WriteLine(nombreJugador + " Vida: " + vidaJugador);
                        Console.WriteLine(nombreEnemigo3 + " Vida: " + vidaEnemigo3);

                        Console.WriteLine("1. Atacar");
                        Console.WriteLine("2. Usar item");
                        int opcion = int.Parse(Console.ReadLine());

                        if (opcion == 1)
                        {
                            vidaEnemigo3 -= danoJugador;
                            Console.WriteLine("Atacaste.");
                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("1. Poción (" + pociones + ")");
                            Console.WriteLine("2. Comida (" + comidas + ")");
                            int item = int.Parse(Console.ReadLine());

                            if (item == 1 && pociones > 0)
                            {
                                vidaJugador += 20;
                                pociones--;
                            }
                            else if (item == 2 && comidas > 0)
                            {
                                vidaJugador += 40;
                                comidas--;
                            }
                            else
                            {
                                Console.WriteLine("No tienes ese item.");
                            }
                        }

                        if (vidaEnemigo3 > 0)
                        {
                            vidaJugador -= danoEnemigo3;
                            Console.WriteLine("El enemigo atacó.");
                        }
                    }

                    // 🔥 DROP TERRAN
                    if (vidaEnemigo3 <= 0)
                    {
                        Console.WriteLine("El Terran dejó una poción.");
                        pociones++;
                    }
                }    }

            // ===== FINAL =====
            if (vidaJugador > 0)
            {
                Console.WriteLine("\n¡Derrotaste a todos los enemigos!");
            }
            else
            {
                Console.WriteLine("\nPerdiste...");
            }

            Console.ReadLine();
        }
    }
}