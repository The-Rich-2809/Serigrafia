using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClassDetalle_Venta
    {
        public int Id_DetalleVenta { get; set; }
        public required ClassProducto OProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public required string FechaRegistro { get; set; }

    }
}
