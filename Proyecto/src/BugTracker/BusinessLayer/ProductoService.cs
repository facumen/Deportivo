using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Entities;
using BugTracker.DataAccessLayer;

namespace BugTracker.BusinessLayer
{
    public class ProductoService
    {
        private ProductoDao oProductoDao;
        public ProductoService()
        {
            oProductoDao = new ProductoDao();
        }

        public IList<Producto> ConsultarProductosConFiltrosCondiciones(String condiciones)
        {
            return oProductoDao.GetProductoByFiltersCondiciones(condiciones);
        }


        public Producto ConsultarProductosPorId(int id)
        {
            return oProductoDao.GetProductoById(id);
        }
    }
}
