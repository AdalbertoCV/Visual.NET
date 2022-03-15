using System;

namespace Examen1.Models
{
    class MenuJuego
    {
        private juego juego;

        public MenuJuego()
        {
            juego = new juego();
            Console.WriteLine("---Iniciando nuevo juego---");
            juego.verBalance();
        }

        public void imprimirOpciones()
        {
            Console.WriteLine("---Seleccione una opcion---");
            Console.WriteLine("1) Jugada nueva.");
            Console.WriteLine("2) Ver balance.");
            Console.WriteLine("3) Ver cantidad de jugadas realizadas.");
            Console.WriteLine("4) Ver numero que mas veces se ha tirado.");
            Console.WriteLine("5) Ver numero que menos veces se ha tirado.");
            Console.WriteLine("6) Ver cantidad de resultados extremos.");
            Console.WriteLine("7) Ver cantidad de resultados medios.");
            Console.WriteLine("8) Ver cantidad de resultados pares.");
            Console.WriteLine("9) Ver cantidad de resultados impares.");
            Console.WriteLine("10) Salir.");
        }

        public void imprimirOpcionesJugada()
        {
            Console.WriteLine("---Seleccione su tipo de jugada---");
            Console.WriteLine("1) Apostar por un numero especifico (2-12).");
            Console.WriteLine("2) Apostar por un numero Extremo.");
            Console.WriteLine("3) Apostar por un numero Medio.");
            Console.WriteLine("4) Apostar por un numero Par.");
            Console.WriteLine("5) Apostar por un numero Impar.");
        }

        public void ejecutarOpcion()
        {
            int opcion = pedirOpcion();
            if (opcion == 1)
            {
                if (!(juego.dinero <= 0))
                {
                    Console.Clear();
                    ejecutarJugada();
                }
                else
                {
                    Console.WriteLine("Lo sentimos. No hay dinero disponible");
                    Environment.Exit(0);
                }
            }
            else
            {
                if (opcion == 2)
                {
                    Console.Clear();
                    juego.verBalance();
                }
                else
                {
                    if (opcion == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Cantidad de jugadas realizadas: " + juego.cantidadTiradas());
                    }
                    else
                    {
                        if (opcion == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Numero mas tirado: " + juego.numeroMasTirado());
                        }
                        else
                        {
                            if (opcion == 5)
                            {
                                Console.Clear();
                                Console.WriteLine("Numero menos tirado: " + juego.numeroMenosTirado());
                            }
                            else
                            {
                                if (opcion == 6)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Cantidad de extremos obtenidos: " + juego.cantidadExtremos());
                                }
                                else
                                {
                                    if (opcion == 7)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Cantidad de medios obtenidos: " + juego.cantidadMedios());
                                    }
                                    else
                                    {
                                        if (opcion == 8)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Cantidad de pares obtenidos: " + juego.cantidadPares());
                                        }
                                        else
                                        {
                                            if (opcion == 9)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Cantidad de impares obtenidos: " + juego.cantidadImpares());
                                            }
                                            else
                                            {
                                                if (opcion == 10)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Gracias por jugar :)");
                                                    Environment.Exit(0);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public int pedirOpcionJugada()
        {
            int opcion = 0;
            do
            {
                imprimirOpcionesJugada();
                opcion = int.Parse(Console.ReadLine());
            } while (opcion < 1 || opcion > 5);
            return opcion;
        }

        public int pedirOpcion()
        {
            int opcion = 0;
            do
            {
                imprimirOpciones();
                opcion = int.Parse(Console.ReadLine());
            } while (opcion < 1 || opcion > 10);
            return opcion;
        }

        public void ejecutarJugada()
        {
            int apuesta = 0;
            do
            {
                Console.WriteLine("Ingrese la cantidad a apostar (Multiplo de 10):");
                apuesta = int.Parse(Console.ReadLine());
                if (!(apuesta % 10 == 0) || apuesta<=0)
                {
                    Console.WriteLine("Error. La cantidad debe ser multiplo de 10 y debe ser mayor a 0");
                }
            } while (!(apuesta%10==0) || apuesta <=0);
            int opcion = pedirOpcionJugada();
            if (opcion == 1)
            {
                int num=0;
                do
                {
                    Console.WriteLine("Ingrese el numero al cual desea apostar (2 - 12):");
                    num = int.Parse(Console.ReadLine());
                } while (num < 2 || num > 12);
                jugada jugadaActual = new jugada(1, apuesta);
                jugadaActual.tirarDados();
                jugadaActual.evaluarResultadoDados();
                jugadaActual.evaluarJugadaExacta(num);
                Console.WriteLine(jugadaActual.ToString());
                juego.agregarJugada(jugadaActual);
            }
            else
            {
                if (opcion == 2)
                {
                    jugada jugadaActual = new jugada(2, apuesta);
                    jugadaActual.tirarDados();
                    jugadaActual.evaluarResultadoDados();
                    jugadaActual.evaluarJugadaExtremos();
                    Console.WriteLine(jugadaActual.ToString());
                    juego.agregarJugada(jugadaActual);
                }
                else
                {
                    if (opcion == 3)
                    {
                        jugada jugadaActual = new jugada(3, apuesta);
                        jugadaActual.tirarDados();
                        jugadaActual.evaluarResultadoDados();
                        jugadaActual.evaluarJugadaMedios();
                        Console.WriteLine(jugadaActual.ToString());
                        juego.agregarJugada(jugadaActual);
                    }
                    else
                    {
                        if (opcion == 4)
                        {
                            jugada jugadaActual = new jugada(4, apuesta);
                            jugadaActual.tirarDados();
                            jugadaActual.evaluarResultadoDados();
                            jugadaActual.evaluarJugadaPar();
                            Console.WriteLine(jugadaActual.ToString());
                            juego.agregarJugada(jugadaActual);
                        }
                        else
                        {
                            if (opcion == 5)
                            {
                                jugada jugadaActual = new jugada(5, apuesta);
                                jugadaActual.tirarDados();
                                jugadaActual.evaluarResultadoDados();
                                jugadaActual.evaluarJugadaImpar();
                                Console.WriteLine(jugadaActual.ToString());
                                juego.agregarJugada(jugadaActual);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Fin de la jugada... Enter para continuar.");
            Console.ReadLine();
            Console.Clear();
        }
    }
} 