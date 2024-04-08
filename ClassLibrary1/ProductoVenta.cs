using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ProductoVenta
    {
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public Venta Venta { get; set; }
        public int Cantidad { get; set; }
    }
}
