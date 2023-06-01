using System;

namespace Programa_de_prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();

            operaciones.Cliente();
            operaciones.Articulos();
            operaciones.Cantidades();
            operaciones.operaciones();
            operaciones.MostrarDatos();
            
        }
    }
}
