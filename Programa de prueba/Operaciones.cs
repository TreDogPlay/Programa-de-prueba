using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Programa_de_prueba
{
    public class Operaciones
    { 
        Usuario usuario = new Usuario();
        Direccion direccion = new Direccion();
        Articulo[] articulo = new Articulo[5];
        int[] cantidades = new int[5];
        double totalCompra = 0;
       
        
        public void Cliente()
        { 
            Console.WriteLine("ingrese su nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su correo: ");
            usuario.Correo = Console.ReadLine();
            Console.WriteLine("Ingrese su manzana: ");
            direccion.Manzana = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su lote: ");
            direccion.Lote = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su region: ");
            direccion.Region = int.Parse(Console.ReadLine());


        }
        public void Articulos()
        {

            articulo[0] = new Articulo { Nombre = "Telefono valor 200 pesos", Precio = 200 };
            articulo[1] = new Articulo { Nombre = "Pantalla valor 300 pesos", Precio = 300 };
            articulo[2] = new Articulo { Nombre = "Teclado valor 50 pesos", Precio = 50 };
            articulo[3] = new Articulo { Nombre = "Mouse valor 35 pesos", Precio = 35 };
            articulo[4] = new Articulo { Nombre = "Audifono valor 120 pesos", Precio = 120 };
        }

        public void Cantidades()
        {

            for (int i = 0; i < cantidades.Length; i++)
            {
                Console.WriteLine($"Ingrese la cantidad deseada de {articulo[i].Nombre}");
                cantidades[i] = int.Parse(Console.ReadLine());

            }
                

                for (int i = 0; i < articulo.Length; i++)
                {
                    totalCompra += articulo[i].Precio * cantidades[i];
                }
            }
        
        public void operaciones()
        {
            double IVA = totalCompra * .16;
            if (totalCompra < 1000)
            {
                Console.WriteLine($"el subtotal de su pago sera de {totalCompra + 250} pesos mexicanos ");
                Console.WriteLine($"El IVA de su compra es de {IVA.ToString("0.00")} Pesos mexicanos");
                Console.WriteLine($"Su pago sera de {totalCompra+IVA} MXN");
            }
           else if(totalCompra > 1000)
            {
                //Console.WriteLine("Tienes la opcion de pagar a 3 meses sin interes, deseas agarrarlo?");
                //string respuesta = Console.ReadLine();
                //if (respuesta == "Si" || respuesta == "si" || respuesta == "SI")
                {
                    Console.WriteLine($"Su pago sera a 3 meses sin intereses, el subtotal de su compra es de {totalCompra} pesos");
                    Console.WriteLine($"El IVA de su compra es de {IVA} pesos mexicanos");
                    Console.WriteLine($"El total es {totalCompra+IVA} pesos mexicanos");
                    Console.WriteLine($"El pago al mes sera de {totalCompra/3} MXN");
                }
                //else if (respuesta == "No" || respuesta == "no")
                //{
                //    Console.WriteLine($"El subtotal de su compra es de {totalCompra} pesos mexicanos");
                //    Console.WriteLine($"El IVA de su compra es de {IVA} pesos mexicanos");
                //    Console.WriteLine($"El total es {totalCompra + IVA} pesos mexicanos");

                //}
            }
           
        }
        public void MostrarDatos()
        {
            Console.WriteLine("\nDatos del cliente:");
            Console.WriteLine("Nombre: " + usuario.Nombre);
            Console.WriteLine("Correo " + usuario.Correo);
            Console.WriteLine($"Su direccion es: Region: {direccion.Region} Manzana: {direccion.Manzana} Lote: {direccion.Lote}");
            Console.WriteLine("El total de su compra es de: $" + totalCompra.ToString("0.00"));
        }
    }
}
