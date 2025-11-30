using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIST_INVT.Entities
{
    public class Activo
    {
        public int id_activo { get; set; }
        public String codigo { get; set; }
        public String descripcion { get; set; }
        public Categoria categoria { get; set; }
        public Area area { get; set; }
        public Personal Usuario { get; set; }
        public String marca { get; set; }
        public String modelo { get; set; }
        public String numero_serie { get; set; }
        public DateTime fecha_compra { get; set; }
        public float valor_compra { get; set; }
        public String estado { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime fecha_modificacion { get; set; }
        public String vida_util_anios { get; set; }
    }
}
