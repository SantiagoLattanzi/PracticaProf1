using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Producto
    {
        public TipoProducto TipoProduc { get; set; }
        public Tamaños Tamaño { get; set; }
        public string Descripcion { get; set; }
        public int Unitario { get; set; }
        public int Stock { get; set; }

        public Producto(TipoProducto tipoproduc, Tamaños tamaño, string descripcion, int unitario, int stock)
        {
            TipoProduc = tipoproduc;
            Tamaño = tamaño;
            Descripcion = descripcion;
            Unitario = unitario;
            Stock = stock;

        }
    }
}
