using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIST_INVT.Entities
{
    public class Personal
    {
        public int IdUsuario { get; set; }
        public String Codigo { get; set; }
        public String Usuario { get; set; }
        public String Clave { get; set; }
        public String Rol { get; set; }
        public String Nombres { get; set; }
        public String ApePaterno { get; set; }
        public String ApeMaterno { get; set; }
        public String TipoDoc { get; set; }
        public String NumDoc { get; set; }
        public String Email { get; set; }
        public String Teléfono { get; set; }
        public Area Area { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
