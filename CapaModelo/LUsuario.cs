using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class LUsuario
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DescripcionReferencia { get; set; }
        public int IdReferencia { get; set; }
        public string LoginUsuario { get; set; }
        public string Clave { get; set; }
        public int IdRol { get; set; }
        public LRol oRol { get; set; }
        public List<LMenu> oListaMenu { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
