namespace Tarea2.Models
{
    class Pelicula
    {
        private string _nombre_pelicula;
        private string _categoria_pelicula;
        private string _formato_pelicula;

        public Pelicula(string nombre, string categoria, string formato)
        {
            _nombre_pelicula = nombre;
            _categoria_pelicula = categoria;
            _formato_pelicula = formato;
        }

        public string nombre_pelicula
        {
            get { return _nombre_pelicula; }
            set { _nombre_pelicula = value; }
        }

        public string categoria_pelicula
        {
            get { return _categoria_pelicula; }
            set { _categoria_pelicula = value; }
        }

        public string formato_pelicula
        {
            get { return _formato_pelicula; }
            set { _formato_pelicula = value; }
        }

        public override string ToString()
        {
            return $"Nombre Pelicula: {_nombre_pelicula}, Categoria: {_categoria_pelicula}, Formato: {_formato_pelicula}";
        }
    }
}
