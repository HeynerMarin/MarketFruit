using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageMarketFruit
{
    public class Compras
    {
        public string Id { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string TipoVehiculo { get; set; } = string.Empty;
        public int IdVehiculo { get; set; } 
        public string EstadoPedido { get; set; } = string.Empty;
    }
}