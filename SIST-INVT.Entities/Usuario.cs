using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIST_INVT.Entities
{
    internal class Usuario
    {
        public int id_usuario { get; set; }
        public String codigo_usuario { get; set; }
        public String nombres { get; set; }
        public String apellido_paterno { get; set; }
        public String apellido_materno { get; set; }
        public String tipo_documento { get; set; }
        public String numero_documento { get; set; }
        public String correo { get; set; }
        public String teléfono { get; set; }
        public String usuario { get; set; }
        public String clave { get; set; }
        public String rol { get; set; }
        public DateTime fecha_creacion { get; set; }
    }
}
