using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIST_INVT.Entities
{
    internal class Detalle_Movimiento
    {
        public int id_detalle_mov { get; set; }
        public Movimiento movimiento { get; set; }
        public Activo activo { get; set; }
        public String estado_anterior { get; set; }
        public String estado_nuevo { get; set; }
        public String observaciones { get; set; }

    }
}
