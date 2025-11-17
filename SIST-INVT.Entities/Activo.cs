using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIST_INVT.Entities
{
    internal class Activo
    {
        public int id_activo { get; set; }
        public String codigo_activo { get; set; }
        public String descripción { get; set; }
        public String categoria { get; set; }
        public String marca { get; set; }
        public String modelo { get; set; }
        public String numero_serie { get; set; }
        public String estado { get; set; }
        public DateTime fecha_compra { get; set; }
        public float valor_compra { get; set; }
        public String vida_util_anios { get; set; }
        public float valor_residual { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
