using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIST_INVT.Entities
{
    internal class Mantenimiento
    {
        public int id_mantenimiento { get; set; }
        public String codigo_mantenimiento { get; set; }
        public Usuario usuario { get; set; }
        public String tipo_mantenimiento { get; set; }
        public String descripcion_general { get; set; }
        public DateTime fecha_programada { get; set; }
        public DateTime fecha_ejecucion { get; set; }
        public float costo_total { get; set; }
        public String estado { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
