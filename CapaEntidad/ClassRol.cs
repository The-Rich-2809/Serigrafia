using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClassRol
    {
        public int ID_Rol { get; set; }
        public required string Descripcion { get; set; }

        public required string FechaRegistro { get; set;}
    }
}
