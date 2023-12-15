using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClassVenta
    {

        public int Id_Venta { get; set; }
        public required ClassUsuario OUsuario { get; set; }
        public required string TipoUsuario { get; set; }
        public required string NoUsuario { get; set; }
        public required string NombreCliente { get; set; }
        public decimal Monto_Pago { get; set; }
        public decimal Monto_Total { get; set; }
        public decimal Monto_Cambio { get; set; }
        public required string FechaRegistro { get; set; }
    }
}
