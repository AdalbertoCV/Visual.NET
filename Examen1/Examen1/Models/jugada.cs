using System;

namespace Examen1.Models
{
    class jugada
    {
        private string _tipo_jugada;
        private int _dado_1;
        private int _dado_2;
        private string _resultado_jugada;
        private string _resultadoDados;
        private string _resultadoParImpar;
        private int _apuesta;

        public int apuesta
        {
            get { return _apuesta; }
        }
        public string tipoJugada
        {
            get { return _tipo_jugada; }
            set { _tipo_jugada = value; }
        }

        public int dado1
        {
            get { return _dado_1; }
        }
        public int dado2
        {
            get { return _dado_2; }
        }

        public string resultado
        {
            get { return _resultado_jugada; }
        }

        public string resultadoDados
        {
            get { return _resultadoDados; }
            set { _resultadoDados = value; }
        }

        public string resultadoParImpar
        {
            get { return _resultadoParImpar; }
            set { _resultadoParImpar = value; }
        }
        public jugada(int numeroTipo, int ap)
        {
            _apuesta = ap;
            _dado_1 = 0;
            _dado_2 = 0;
            _resultado_jugada = "N/A";
            if (numeroTipo == 1)
            {
                _tipo_jugada = "Valor Especifico";
            }
            else
            {
                if (numeroTipo == 2)
                {
                    _tipo_jugada = "Valor Extremo";
                }
                else
                {
                    if (numeroTipo == 3)
                    {
                        _tipo_jugada = "Valor Medio";
                    }
                    else
                    {
                        if (numeroTipo == 4)
                        {
                            _tipo_jugada = "Valor par";
                        }
                        else
                        {
                            if (numeroTipo == 5)
                            {
                                _tipo_jugada = "Valor impar";
                            }
                        }
                    }
                }
            }
        }

        public void tirarDados()
        {
            Random r = new Random();
            _dado_1 = r.Next(1, 7);
            _dado_2 = r.Next(1, 7);
        }

        public void evaluarJugadaExacta(int num)
        {
            if ((dado1 + dado2) == num)
            {
                _resultado_jugada = "Victoria";
            }
            else
            {
                _resultado_jugada = "Derrota";
            }
        }

        public void evaluarJugadaExtremos()
        {
            if (resultadoDados == "Extremo")
            {
                _resultado_jugada = "Victoria";
            }
            else
            {
                _resultado_jugada = "Derrota";
            }

        }

        public void evaluarJugadaMedios()
        {
            if (resultadoDados == "Medio")
            {
                _resultado_jugada = "Victoria";
            }
            else
            {
                _resultado_jugada = "Derrota";
            }
        }

        public void evaluarJugadaPar()
        {
            if (resultadoParImpar == "Par")
            {
                _resultado_jugada = "Victoria";
            }
            else
            {
                _resultado_jugada = "Derrota";
            }
        }

        public void evaluarJugadaImpar()
        {
            if (resultadoParImpar == "impar")
            {
                _resultado_jugada = "Victoria";
            }
            else
            {
                _resultado_jugada = "Derrota";
            }
        }

        public void evaluarResultadoDados()
        {
            if (((dado1 + dado2) == 2) || ((dado1 + dado2) == 3) || ((dado1 + dado2) == 4) || ((dado1 + dado2) == 10) || ((dado1 + dado2) == 11) || ((dado1 + dado2) == 12))
            {
                resultadoDados = "Extremo";
            }
            else
            {
                if (((dado1 + dado2) == 5) || ((dado1 + dado2) == 6) || ((dado1 + dado2) == 7) || ((dado1 + dado2) == 8) || ((dado1 + dado2) == 9))
                {
                    resultadoDados = "Medio";
                }
            }

           
           if ((dado1 + dado2) % 2 == 0)
           {
               resultadoParImpar = "Par";
           }
           else
           {
                resultadoParImpar = "impar";
           }
        }

        public override string ToString()
        {
            return $"Jugada: {tipoJugada}, resultado dado1: {dado1}, resultado dado2: {dado2},suma dados: {dado1 + dado2} ,resultado final: {resultado}";
        }
    }
} 