using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClassProducto
    {
        public int Id_Producto { get; set; }
        public required string Codigo { get; set; }
        public required string Nombre { get; set; }
        public required string Descripcion { get; set; }
        public required ClassCatalogo OCatalogo { get; set; }
        public required int Stock { get; set; }
        public required decimal Precio_Compra {  get; set; }
        public required decimal Precio_Venta { get; set; }
        public required bool Estado { get; set; }
        public required string FechaRegistro { get; set; }

    }
}
