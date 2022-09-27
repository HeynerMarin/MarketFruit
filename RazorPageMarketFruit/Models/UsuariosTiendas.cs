using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageMarketFruit
{
    public class UsuariosTiendas : Usuarios
    {
        public Catalogo Catalogo { get; set;} = default!;
        public string HorarioAtencion { get; set; } = string.Empty;
        public string NombreTienda { get; set; } = string.Empty;
        public int Nit { get; set; }
        public Domicilios Domicilios { get; set; } = default!;
    }
}