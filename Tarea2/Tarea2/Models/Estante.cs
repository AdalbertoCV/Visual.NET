using System;
using System.Collections.Generic;

namespace Tarea2.Models
{
    class Estante
    {
        private List<Pelicula> _lista_accion;
        private List<Pelicula> _lista_terror;
        private List<Pelicula> _lista_romance;
        private List<Pelicula> _lista_comedia;
        private List<Pelicula> _lista_animadas;

        public Estante()
        {
            _lista_accion = new List<Pelicula>();
            _lista_terror = new List<Pelicula>();
            _lista_romance = new List<Pelicula>();
            _lista_comedia = new List<Pelicula>();
            _lista_animadas = new List<Pelicula>();
        }

        public void agregarAccion(Pelicula pelicula)
        {
            _lista_accion.Add(pelicula);
        }

        public void agregarTerror(Pelicula pelicula)
        {
            _lista_terror.Add(pelicula);
        }

        public void agregarRomance(Pelicula pelicula)
        {
            _lista_romance.Add(pelicula);
        }

        public void agregarComedia(Pelicula pelicula)
        {
            _lista_comedia.Add(pelicula);
        }

        public void agregarAnimada(Pelicula pelicula)
        {
            _lista_animadas.Add(pelicula);
        }

        public void mostrarPeliculasAccion()
        {
            for (int pos =0; pos < _lista_accion.Count; pos++)
            {
                Console.WriteLine(_lista_accion[pos]);
            }
        }

        public void mostrarPeliculasTerror()
        {
            for (int pos = 0; pos < _lista_terror.Count; pos++)
            {
                Console.WriteLine(_lista_terror[pos]);
            }
        }

        public void mostrarPeliculasRomance()
        {
            for (int pos = 0; pos < _lista_romance.Count; pos++)
            {
                Console.WriteLine(_lista_romance[pos]);
            }
        }

        public void mostrarPeliculasComedia()
        {
            for (int pos = 0; pos < _lista_comedia.Count; pos++)
            {
                Console.WriteLine(_lista_comedia[pos]);
            }
        }

        public void mostrarPeliculasAnimadas()
        {
            for (int pos = 0; pos < _lista_animadas.Count; pos++)
            {
                Console.WriteLine(_lista_animadas[pos]);
            }
        }
    }
} 