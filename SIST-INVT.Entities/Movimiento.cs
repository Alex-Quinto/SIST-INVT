using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIST_INVT.Entities
{
    internal class Movimiento
    {
        public int id_movimiento { get; set; }
        public String codigo_movimiento { get; set; }
        public Usuario usuario { get; set; }
        public String tipo_movimiento { get; set; }
        public String ubicacion_origen { get; set; }
        public String ubicacion_destino { get; set; }
        public DateTime fecha_movimiento { get; set; }
        public String observaciones { get; set; }

    }
}
