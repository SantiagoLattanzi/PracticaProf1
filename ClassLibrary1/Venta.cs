using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Venta
    {
        public Cliente cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoTotal { get; set; }
        public List<ProductoVenta> Carrito { get; set; }

        public Venta(Cliente cliente, DateTime fecha, decimal montoTotal)
        {
            this.cliente = cliente;
            Fecha = fecha;
            MontoTotal = montoTotal;
            Carrito = new List<ProductoVenta>();
        }

        public void AgregarProducto(int id, Producto producto, Venta venta, int cantidad )
        {
            Carrito.Add((new ProductoVenta { Id = id, Producto = producto, Venta = venta, Cantidad = cantidad }));
        }

    }
}