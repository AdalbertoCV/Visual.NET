using System;
using Tarea2;

int opcion;
Console.WriteLine("Bienvenido Profe, Cual de los dos programas quiere probar?");
Console.WriteLine("(1) Peliculas");
Console.WriteLine("(2) Ventas");

opcion = int.Parse(Console.ReadLine());

if (opcion == 1)
{
    MenuPeliculas menuPeliculas = new MenuPeliculas();

    do
    {
        menuPeliculas.ejecutarOpcion(menuPeliculas.pedirOpcion());
    } while (true);
}
else
{
    if (opcion == 2)
    {
        MenuVentas menu = new MenuVentas();
        do
        {
            menu.ejecutarOpcion(menu.pedirOpcion());
        } while (true);
    }
}

