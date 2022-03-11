using System;
using Tarea2.Models;

namespace Tarea2
{
    class MenuVentas
    {
        private ControlVentas controlador;

        public MenuVentas()
        {
            controlador = new ControlVentas();
        }

        public void imprimirOpciones()
        {
            Console.WriteLine("Seleccione una opcion.");
            Console.WriteLine("(1) Agregar Venta.");
            Console.WriteLine("(2) Ver Tipo de producto mas vendido.");
            Console.WriteLine("(3) Ver lista de ventas.");
            Console.WriteLine("(4) Salir.");
        }

        public int pedirOpcion()
        {
            int number = 0;
            do
            {
                imprimirOpciones();
                string entrada = Console.ReadLine();
                Int32.TryParse(entrada, out number);
            } while (number < 1 || number > 4);
            return number;
        }

        public void ejecutarOpcion(int opcion)
        {
            if (opcion == 1)
            {
                agregarVenta();
            }
            else
            {
                if (opcion == 2)
                {
                    Console.WriteLine(controlador.obtenerTipoDeProductoQueMasSeVende());
                }
                else
                {
                    if (opcion == 3)
                    {
                        controlador.imprimirVentas();
                    }
                    else
                    {
                        if (opcion == 4)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }

        private void agregarVenta()
        {
            string nombreProducto;
            string tipo;
            int precio;
            do
            {
                Console.WriteLine("Nombre del producto vendido: ");
                nombreProducto = Console.ReadLine();
                Console.WriteLine("Tipo del producto vendido (Fritura, Gaseosa, Jugo, Pan, Verdura, Fruta, Dulce, Limpieza)");
                tipo = Console.ReadLine();
                Console.WriteLine("Precio del producto vendido:");
                precio = int.Parse(Console.ReadLine());
                if (nombreProducto == ""|| tipo=="" || (tipo!="Fritura" && tipo!="Gaseosa" && tipo!="Jugo" && tipo!="Pan" && tipo!="Verdura" && tipo!="Fruta" && tipo!="Dulce" && tipo!="Limpieza"))
                {
                    Console.WriteLine("Datos invalidos.");
                }
            } while (nombreProducto == "" || tipo == "" || (tipo != "Fritura" && tipo != "Gaseosa" && tipo != "Jugo" && tipo != "Pan" && tipo != "Verdura" && tipo != "Fruta" && tipo != "Dulce" && tipo != "Limpieza"));

            Venta venta = new Venta(nombreProducto, tipo, precio);
            controlador.agregarVenta(venta);
            Console.WriteLine("Venta registrada exitosamente");
        }
    }
}