using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIST_INVT.Entities
{
    public class Baja
    {
        public int id_baja { get; set; }
        public String codigo { get; set; }
        public Activo activo { get; set; }
        public DateTime fecha { get; set; }
        public String motivo { get; set; }
        public String descripcion { get; set; }
        public float valor_residual { get; set; }
        public DateTime fecha_creacion { get; set; }
    }
}
