using System;
using System.Collections.Generic;

namespace Tarea2.Models
{
    class ControlVentas
    {
        private List<Venta> listaVentas;

        public ControlVentas()
        {
            listaVentas = new List<Venta>();
        }

        public void agregarVenta(Venta venta)
        {
            listaVentas.Add(venta);
        }

        public string obtenerTipoDeProductoQueMasSeVende()
        {
            List<int> contadores = new List<int>();
            int contFrituras = 0;
            int contGaseosas = 0;
            int contJugos = 0;
            int contPanes = 0;
            int contVerduras = 0;
            int contFrutas = 0;
            int contDulces = 0;
            int contLimpieza = 0;
            for (int pos=0; pos< listaVentas.Count; pos++)
            {
                if (listaVentas[pos].tipo_Producto.Equals("Fritura"))
                {
                    contFrituras++;
                }
                else
                {
                    if (listaVentas[pos].tipo_Producto.Equals("Gaseosa"))
                    {
                        contGaseosas++;
                    }
                    else
                    {
                        if (listaVentas[pos].tipo_Producto.Equals("Jugo"))
                        {
                            contJugos++;
                        }
                        else
                        {
                            if (listaVentas[pos].tipo_Producto.Equals("Pan"))
                            {
                                contPanes++;
                            }
                            else
                            {
                                if (listaVentas[pos].tipo_Producto.Equals("Verdura"))
                                {
                                    contVerduras++;
                                }
                                else
                                {
                                    if (listaVentas[pos].tipo_Producto.Equals("Fruta"))
                                    {
                                        contFrutas++;
                                    }
                                    else
                                    {
                                        if (listaVentas[pos].tipo_Producto.Equals("Dulce"))
                                        {
                                            contDulces++;
                                        }
                                        else
                                        {
                                            if (listaVentas[pos].tipo_Producto.Equals("Limpieza"))
                                            {
                                                contLimpieza++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            contadores.Add(contFrituras);
            contadores.Add(contGaseosas);
            contadores.Add(contJugos);
            contadores.Add(contPanes);
            contadores.Add(contVerduras);
            contadores.Add(contFrutas);
            contadores.Add(contDulces);
            contadores.Add(contLimpieza);

            if (listaVentas.Count != 0)
            {
                int posMayor = 0;
                int mayor = contadores[0];
                for (int pos = 0; pos < contadores.Count; pos++)
                {
                    if (contadores[pos] > mayor)
                    {
                        mayor = contadores[pos];
                        posMayor = pos;
                    }
                }

                if (posMayor == 0)
                {
                    return "El tipo mas vendido es Frituras";
                }
                else
                {
                    if (posMayor == 1)
                    {
                        return "El tipo mas vendido es Gaseosas";
                    }
                    else
                    {
                        if (posMayor == 2)
                        {
                            return "El tipo mas vendido es Jugos";
                        }
                        else
                        {
                            if (posMayor == 3)
                            {
                                return "El tipo mas vendido es Panes";
                            }
                            else
                            {
                                if (posMayor == 4)
                                {
                                    return "El tipo mas vendido es Verduras";
                                }
                                else
                                {
                                    if (posMayor == 5)
                                    {
                                        return "El tipo mas vendido es Frutas";
                                    }
                                    else
                                    {
                                        if (posMayor == 6)
                                        {
                                            return "El tipo mas vendido es Dulces";
                                        }
                                        else
                                        {
                                            if (posMayor == 7)
                                            {
                                                return "El tipo mas vendido es productos de limpieza";
                                            }
                                            else
                                            {
                                                return "No hay un producto mas vendido";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                return "No hay ventas";
            }
        }

        public void imprimirVentas()
        {
            for (int pos=0; pos< listaVentas.Count; pos++)
            {
                Console.WriteLine(listaVentas[pos].ToString());
            }
        }
    }
} 