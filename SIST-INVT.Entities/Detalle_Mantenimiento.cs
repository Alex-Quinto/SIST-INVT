using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIST_INVT.Entities
{
    internal class Detalle_Mantenimiento
    {
        public int id_detalle_mant { get; set; }
        public Mantenimiento mantenimiento { get; set; }
        public Activo activo { get; set; }
        public String observaciones { get; set; }
        public float costo_individual { get; set; }

    }
}
