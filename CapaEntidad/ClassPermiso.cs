using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClassPermiso
    {
        public  int Id_Permiso {  get; set; }
        public required ClassRol ORol  { get; set; }
        public required string NombreMenu { get; set; }
        public required string FechaRegistro { get; set; }
    }
}
