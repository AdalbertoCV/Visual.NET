namespace Tarea2.Models
{
    class Venta
    {
        protected string _nombreProducto;
        protected string _tipoProducto;
        protected int _precio;

        public Venta(string nombre, string tipo, int precio)
        {
            _nombreProducto = nombre;
            _tipoProducto = tipo;
            _precio = precio;
        }

        public string nombre_Producto
        {
            get { return _nombreProducto; }
            set { _nombreProducto = value; }
        }

        public string tipo_Producto
        {
            get { return _tipoProducto; }
            set { _tipoProducto = value; }
        }

        public int precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public override string ToString()
        {
            return $"Nombre Producto: {_nombreProducto}, Tipo: {_tipoProducto}, Precio: {_precio}";
        }
    }
} 