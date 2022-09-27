using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageMarketFruit
{
    public class Catalogo
    {
        public int Id { get; set; }
        public string NombreProductos { get; set; } = string.Empty;
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; } = string.Empty;

    }
}