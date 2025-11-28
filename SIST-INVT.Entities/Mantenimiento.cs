using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIST_INVT.Entities
{
    public class Mantenimiento
    {
        public int id_mantenimiento { get; set; }
        public String codigo { get; set; }
        public Activo activo { get; set; }
        public String tipo { get; set; }
        public DateTime fecha { get; set; }
        public String proveedor { get; set; }
        public float costo { get; set; }
        public String descripcion { get; set; }
        public DateTime fecha_creacion { get; set; }

    }
}
