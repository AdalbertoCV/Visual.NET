using System;
using Tarea2.Models;

namespace Tarea2
{
    class MenuPeliculas
    {
        private Estante estanteDVD;
        private Estante estanteBR;
        private Estante estantVHS;

        public MenuPeliculas()
        {
            estanteBR = new Estante();
            estanteDVD = new Estante();
            estantVHS = new Estante();
        }

        public void imprimirOpciones()
        {
            Console.WriteLine("Seleccione una opcion.");
            Console.WriteLine("(1) Agregar pelicula.");
            Console.WriteLine("(2) Ver VHS.");
            Console.WriteLine("(3) Ver Dvds.");
            Console.WriteLine("(4) Ver blu-rays.");
            Console.WriteLine("(5) Salir.");
        }

        public int pedirOpcion()
        {
            int number = 0;
            do
            {
                imprimirOpciones();
                string entrada = Console.ReadLine();
                Int32.TryParse(entrada, out number);
            } while (number < 1 || number > 5);
            return number;
        }

        public int pedirOpcionPeliculas()
        {
            int number = 0;
            do
            {
                mostrarOpcionesPeliculas();
                string entrada = Console.ReadLine();
                Int32.TryParse(entrada, out number);
            } while (number < 1 || number > 5);
            return number;
        }

        public void ejecutarOpcion(int opcion)
        {
            if (opcion == 1)
            {
                agregarPelicula();
            }
            else
            {
                if (opcion == 2)
                {
                    mostrarPeliculasVHS();
                }
                else
                {
                    if (opcion == 3)
                    {
                        mostrarPeliculasDVD();
                    }
                    else
                    {
                        if (opcion == 4)
                        {
                            mostrarPeliculasBR();
                        }
                        else
                        {
                            if (opcion == 5)
                            {
                                Environment.Exit(0);
                            }
                        }
                    }
                }
            }
        }


        private void mostrarPeliculasBR()
        {
            int opcion = pedirOpcionPeliculas();
            if (opcion == 1)
            {
                estanteBR.mostrarPeliculasAccion();
            }
            else
            {
                if (opcion == 2)
                {
                    estanteBR.mostrarPeliculasTerror();
                }
                else
                {
                    if (opcion == 3)
                    {
                        estanteBR.mostrarPeliculasRomance();
                    }
                    else
                    {
                        if (opcion == 4)
                        {
                            estanteBR.mostrarPeliculasComedia();
                        }
                        else
                        {
                            if (opcion == 5)
                            {
                                estanteBR.mostrarPeliculasAnimadas();
                            }
                        }
                    }
                }
            }
        }

        private void mostrarPeliculasDVD()
        {
            int opcion = pedirOpcionPeliculas();
            if (opcion == 1)
            {
                estanteDVD.mostrarPeliculasAccion();
            }
            else
            {
                if (opcion == 2)
                {
                    estanteDVD.mostrarPeliculasTerror();
                }
                else
                {
                    if (opcion == 3)
                    {
                        estanteDVD.mostrarPeliculasRomance();
                    }
                    else
                    {
                        if (opcion == 4)
                        {
                            estanteDVD.mostrarPeliculasComedia();
                        }
                        else
                        {
                            if (opcion == 5)
                            {
                                estanteDVD.mostrarPeliculasAnimadas();
                            }
                        }
                    }
                }
            }
        }

        private void mostrarPeliculasVHS()
        {
            int opcion = pedirOpcionPeliculas();
            if (opcion == 1)
            {
                estantVHS.mostrarPeliculasAccion();
            }
            else
            {
                if (opcion == 2)
                {
                    estantVHS.mostrarPeliculasTerror();
                }
                else
                {
                    if (opcion == 3)
                    {
                        estantVHS.mostrarPeliculasRomance();
                    }
                    else
                    {
                        if (opcion == 4)
                        {
                            estantVHS.mostrarPeliculasComedia();
                        }
                        else
                        {
                            if (opcion == 5)
                            {
                                estantVHS.mostrarPeliculasAnimadas();
                            }
                        }
                    }
                }
            }
        }

        private void mostrarOpcionesPeliculas()
        {
            Console.WriteLine("(1) Ver Peliculas accion");
            Console.WriteLine("(2) Ver Peliculas terror");
            Console.WriteLine("(3) Ver Peliculas romance");
            Console.WriteLine("(4) Ver Peliculas comedia");
            Console.WriteLine("(5) Ver Peliculas animadas");

        }

        private void agregarPelicula()
        {
            string nombrePelicula;
            string categoria;
            string formato;
            do
            {
                Console.WriteLine("Nombre de la pelicula a agregar: ");
                nombrePelicula = Console.ReadLine();
                Console.WriteLine("Categoria de la pelicula a agregar (Terror, Comedia, Accion, Romance, Animada): ");
                categoria = Console.ReadLine();
                Console.WriteLine("Formato de la pelicula a agregar (VHS, DVD, Blu-ray): ");
                formato = Console.ReadLine();
                if (nombrePelicula == "" || categoria == "" || formato == "" || (categoria != "Terror" && categoria != "Comedia" && categoria != "Romance" && categoria != "Accion" && categoria != "Animada") || (formato != "VHS" && formato != "DVD" && formato != "Blu-ray"))
                {
                    Console.WriteLine("Datos invalidos.");
                }
            } while (nombrePelicula == "" || categoria == "" || formato == "" || (categoria != "Terror" && categoria != "Comedia" && categoria != "Romance" && categoria != "Accion" && categoria != "Animada") || (formato != "VHS" && formato != "DVD" && formato != "Blu-ray"));

            Pelicula pelicula = new Pelicula(nombrePelicula, categoria, formato);
            if (pelicula.formato_pelicula == "VHS")
            {
                if (pelicula.categoria_pelicula == "Terror")
                {
                    estantVHS.agregarTerror(pelicula);
                }
                else
                {
                    if (pelicula.categoria_pelicula == "Comedia")
                    {
                        estantVHS.agregarComedia(pelicula);
                    }
                    else
                    {
                        if (pelicula.categoria_pelicula == "Accion")
                        {
                            estantVHS.agregarAccion(pelicula);
                        }
                        else
                        {
                            if (pelicula.categoria_pelicula == "Romance")
                            {
                                estantVHS.agregarRomance(pelicula);
                            }
                            else
                            {
                                if (pelicula.categoria_pelicula == "Animada")
                                {
                                    estantVHS.agregarAnimada(pelicula);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (pelicula.formato_pelicula == "DVD")
                {
                    if (pelicula.categoria_pelicula == "Terror")
                    {
                        estanteDVD.agregarTerror(pelicula);
                    }
                    else
                    {
                        if (pelicula.categoria_pelicula == "Comedia")
                        {
                            estanteDVD.agregarComedia(pelicula);
                        }
                        else
                        {
                            if (pelicula.categoria_pelicula == "Accion")
                            {
                                estanteDVD.agregarAccion(pelicula);
                            }
                            else
                            {
                                if (pelicula.categoria_pelicula == "Romance")
                                {
                                    estanteDVD.agregarRomance(pelicula);
                                }
                                else
                                {
                                    if (pelicula.categoria_pelicula == "Animada")
                                    {
                                        estanteDVD.agregarAnimada(pelicula);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (pelicula.formato_pelicula == "Blu-ray")
                    {
                        if (pelicula.categoria_pelicula == "Terror")
                        {
                            estanteBR.agregarTerror(pelicula);
                        }
                        else
                        {
                            if (pelicula.categoria_pelicula == "Comedia")
                            {
                                estanteBR.agregarComedia(pelicula);
                            }
                            else
                            {
                                if (pelicula.categoria_pelicula == "Accion")
                                {
                                    estanteBR.agregarAccion(pelicula);
                                }
                                else
                                {
                                    if (pelicula.categoria_pelicula == "Romance")
                                    {
                                        estanteBR.agregarRomance(pelicula);
                                    }
                                    else
                                    {
                                        if (pelicula.categoria_pelicula == "Animada")
                                        {
                                            estanteBR.agregarAnimada(pelicula);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Pelicula Agregada correctamente.");
        }
    }
}



