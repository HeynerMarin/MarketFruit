using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPageMarketFruit
{
    public class UsuariosRegistrados : Usuarios
    {
        [DataType(dataType:DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int Documento { get; set; } 
        public string MetodoPago { get; set; } = string.Empty;
    }
}