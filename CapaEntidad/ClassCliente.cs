﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClassCliente
    {
        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set;}
        public string Telefono { get; set;}
        public bool Estado { get; set;}
        public string FechaRegistro { get; set;}
    }
}
