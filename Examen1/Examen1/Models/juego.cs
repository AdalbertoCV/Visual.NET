using System;
using System.Collections.Generic;

namespace Examen1.Models
{
    class juego
    {
        private List<jugada> jugadas;
        private int _dineroRestante;
        private int _numVictorias;
        private int _numDerrotas;

        public int numDerrotas
        {
            get { return _numDerrotas; }
            set { _numDerrotas = value; }
        }

        public int numVictorias
        {
            get { return _numVictorias; }
            set { _numVictorias = value; }
        }

        public juego()
        {
            jugadas = new List<jugada>();
            _dineroRestante = 300;
            _numDerrotas = 0;
            _numVictorias = 0;
        }

        public int dinero
        {
            get { return _dineroRestante; }
            set { _dineroRestante = value; }
        }

        public void agregarJugada(jugada j)
        {
            if (dinero !=0 || dinero < 0)
            {
                jugadas.Add(j);
                if (j.resultado == "Victoria")
                {
                    numVictorias++;
                    if (j.tipoJugada == "Valor Especifico")
                    {
                        dinero = dinero +  (j.apuesta * 10);
                    }
                    else
                    {
                        if (j.tipoJugada == "Valor Extremo")
                        {
                            dinero = dinero + (j.apuesta * 8);
                        }
                        else
                        {
                            if (j.tipoJugada == "Valor Medio")
                            {
                                dinero = dinero + (j.apuesta * 4);
                            }
                            else
                            {
                                if (j.tipoJugada == "Valor par")
                                {
                                    dinero = dinero + (j.apuesta * 2);
                                }
                                else
                                {
                                    if (j.tipoJugada == "Valor impar")
                                    {
                                        dinero = dinero + (j.apuesta * 2);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    numDerrotas++;
                    dinero = dinero - j.apuesta;
                }
            }
            else
            {
                Console.WriteLine("No hay mas dinero. Fin del juego");
                Environment.Exit(0);
            }
        }

        public void verBalance()
        {
            Console.WriteLine("Victorias: " + numVictorias);
            Console.WriteLine("Derrotas: " + numDerrotas);
            Console.WriteLine("Dinero actual: " + dinero);
        }

        public void verJugadas()
        {
            for (int pos=0; pos < jugadas.Count; pos++)
            {
                Console.WriteLine(jugadas[pos].ToString());
            }
        }

        public int cantidadTiradas()
        {
            return jugadas.Count;
        }

        public int numeroMasTirado()
        {
            List<int> cantidades = new List<int>();
            cantidades.Add(cantidad2());
            cantidades.Add(cantidad3());
            cantidades.Add(cantidad4());
            cantidades.Add(cantidad5());
            cantidades.Add(cantidad6());
            cantidades.Add(cantidad7());
            cantidades.Add(cantidad8());
            cantidades.Add(cantidad9());
            cantidades.Add(cantidad10());
            cantidades.Add(cantidad11());
            cantidades.Add(cantidad12());
            int mayor = cantidades[0];
            int numeroMasTirado = 2;
            for (int pos=0; pos< cantidades.Count; pos++)
            {
                if (cantidades[pos] > mayor)
                {
                    mayor = cantidades[pos];
                    numeroMasTirado = pos + 2;
                }
            }
            return numeroMasTirado;
        }

        public int numeroMenosTirado()
        {
            List<int> cantidades = new List<int>();
            cantidades.Add(cantidad2());
            cantidades.Add(cantidad3());
            cantidades.Add(cantidad4());
            cantidades.Add(cantidad5());
            cantidades.Add(cantidad6());
            cantidades.Add(cantidad7());
            cantidades.Add(cantidad8());
            cantidades.Add(cantidad9());
            cantidades.Add(cantidad10());
            cantidades.Add(cantidad11());
            cantidades.Add(cantidad12());
            int menor = cantidades[0];
            int numeroMenosTirado = 2;
            for (int pos = 0; pos < cantidades.Count; pos++)
            {
                if (cantidades[pos] < menor)
                {
                    menor = cantidades[pos];
                    numeroMenosTirado = pos + 2;
                }
            }
            return numeroMenosTirado;
        }

        public int cantidadExtremos()
        {
            int cantidad = 0;
            for (int pos=0; pos< jugadas.Count; pos++)
            {
                if(jugadas[pos].resultadoDados == "Extremo")
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        public int cantidadMedios()
        {
            int cantidad = 0;
            for (int pos = 0; pos < jugadas.Count; pos++)
            {
                if (jugadas[pos].resultadoDados == "Medio")
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        public int cantidadPares()
        {
            int cantidad = 0;
            for (int pos = 0; pos < jugadas.Count; pos++)
            {
                if (jugadas[pos].resultadoParImpar == "Par")
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        public int cantidadImpares()
        {
            int cantidad = 0;
            for (int pos = 0; pos < jugadas.Count; pos++)
            {
                if (jugadas[pos].resultadoParImpar == "impar")
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        private int cantidad2()
        {
            int cantidad = 0;
            for (int pos =0; pos< jugadas.Count; pos++)
            {
                if ((jugadas[pos].dado1 + jugadas[pos].dado2) == 2)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        private int cantidad3()
        {
            int cantidad = 0;
            for (int pos = 0; pos < jugadas.Count; pos++)
            {
                if ((jugadas[pos].dado1 + jugadas[pos].dado2) == 3)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        private int cantidad4()
        {
            int cantidad = 0;
            for (int pos = 0; pos < jugadas.Count; pos++)
            {
                if ((jugadas[pos].dado1 + jugadas[pos].dado2) == 4)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        private int cantidad5()
        {
            int cantidad = 0;
            for (int pos = 0; pos < jugadas.Count; pos++)
            {
                if ((jugadas[pos].dado1 + jugadas[pos].dado2) == 5)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        private int cantidad6()
        {
            int cantidad = 0;
            for (int pos = 0; pos < jugadas.Count; pos++)
            {
                if ((jugadas[pos].dado1 + jugadas[pos].dado2) == 6)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        private int cantidad7()
        {
            int cantidad = 0;
            for (int pos = 0; pos < jugadas.Count; pos++)
            {
                if ((jugadas[pos].dado1 + jugadas[pos].dado2) == 7)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        private int cantidad8()
        {
            int cantidad = 0;
            for (int pos = 0; pos < jugadas.Count; pos++)
            {
                if ((jugadas[pos].dado1 + jugadas[pos].dado2) == 8)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        private int cantidad9()
        {
            int cantidad = 0;
            for (int pos = 0; pos < jugadas.Count; pos++)
            {
                if ((jugadas[pos].dado1 + jugadas[pos].dado2) == 9)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        private int cantidad10()
        {
            int cantidad = 0;
            for (int pos = 0; pos < jugadas.Count; pos++)
            {
                if ((jugadas[pos].dado1 + jugadas[pos].dado2) == 10)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        private int cantidad11()
        {
            int cantidad = 0;
            for (int pos = 0; pos < jugadas.Count; pos++)
            {
                if ((jugadas[pos].dado1 + jugadas[pos].dado2) == 11)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        private int cantidad12()
        {
            int cantidad = 0;
            for (int pos = 0; pos < jugadas.Count; pos++)
            {
                if ((jugadas[pos].dado1 + jugadas[pos].dado2) == 12)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
    }
}