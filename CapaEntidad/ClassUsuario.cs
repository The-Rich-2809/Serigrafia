using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClassUsuario
    {
        public int Id_Usuario { get; set; }
        public required string Usuario { get; set; }
        public required string Nombre { get; set;}
        public required string Correo { get; set;}
        public required int Contraseña { get; set;}
        public required ClassRol ORol { get; set;}
        public bool Estado { get; set;}
        public required string FechaRegistro { get; set;}
    }
}
