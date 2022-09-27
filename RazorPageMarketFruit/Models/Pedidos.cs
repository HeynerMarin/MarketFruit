using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageMarketFruit
{
    public class Pedidos
    {
        public int Id { get; set; }
        public DateTime FechaPedido { get; set; }
        public UsuariosRegistrados IdUsuarios { get; set; } = default!;
        public int NumProductos { get; set; }
        public int PrecioProducto { get; set; }
        public int Factura { get; set; }
    }
}