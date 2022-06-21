using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class LMenu
    {
        public int IdMenu { get; set; }
        public string Nombre { get; set; }
        public string Icono { get; set; }
        public List<LSubMenu> oSubMenu { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
