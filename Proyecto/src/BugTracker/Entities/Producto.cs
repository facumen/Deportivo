using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
        public Marca Marca { get; set; }
        public int Cantidad{ get; set; }
        public int Precio_Venta { get; set; }
    }
}
