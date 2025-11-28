using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIST_INVT.Entities
{
    public class Categoria
    {
        public int id_categoria { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public DateTime fecha_creacion { get; set; }

    }
}
