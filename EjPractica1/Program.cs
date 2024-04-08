using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace EjPractica1
{
    class Program
    {
        static void Main(string[] args)
        {

            TipoProducto herramienta = new TipoProducto("Herramienta");
            TipoProducto insumo = new TipoProducto("Insumo");
            TipoProducto electricidad = new TipoProducto("Electricidad");


            Tamaños chico = new Tamaños("Chico");
            Tamaños mediano = new Tamaños("Mediano");
            Tamaños grande = new Tamaños("Grande");

            Producto producto1 = new Producto(herramienta, mediano, "Esta es la descripcion ", 12, 20);
            Producto producto2 = new Producto(insumo, chico, "Esta es su descripcion", 15, 50);

            Console.WriteLine("Producto 1:");
            Console.WriteLine($"Descripción: {producto1.Descripcion}");
            Console.WriteLine($"Tipo: {producto1.TipoProduc.Nombre}");
            Console.WriteLine($"Precio Unitario: {producto1.Unitario}");
            Console.WriteLine($"Tamaño: {producto1.Tamaño.Nombre}");
            Console.WriteLine($"Stock: {producto1.Stock}");

            Console.WriteLine();

            Console.WriteLine("Producto 2:");
            Console.WriteLine($"Descripción: {producto2.Descripcion}");
            Console.WriteLine($"Tipo: {producto2.TipoProduc.Nombre}");
            Console.WriteLine($"Precio Unitario: {producto2.Unitario}");
            Console.WriteLine($"Tamaño: {producto2.Tamaño.Nombre}");
            Console.WriteLine($"Stock: {producto2.Stock}");

            Console.ReadLine();
        }
    }
}

