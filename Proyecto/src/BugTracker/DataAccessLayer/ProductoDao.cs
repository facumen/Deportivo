

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using BugTracker.Entities;
using System.Data;

namespace BugTracker.DataAccessLayer
{
    public class ProductoDao
    {
        public Producto GetProductoById(int idProducto)
        {
            var strSql = String.Concat("SELECT producto.id_producto, ",
                                      "        producto.nombre,",
                                      "        producto.id_marca,",
                                      "        marca.descripcion as marca, ",
                                      "        producto.cantidad,",
                                      "        producto.precio_venta",
                                      "        FROM Productos as producto",
                                      "  INNER JOIN Marcas as marca ON  marca.id_marca = producto.id_marca",
                                      " WHERE producto.borrado=0 AND producto.id_producto = " + idProducto.ToString());

            return MappingProducto(DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        public IList<Producto> GetProductoByFiltersCondiciones(String condiciones)
        {
            List<Producto> listadoProductos = new List<Producto>();
            String sqlcondiciones = condiciones;

            var strSql = String.Concat("SELECT producto.id_producto, ",
                                      "        producto.nombre,",
                                      "        producto.id_marca,",
                                      "        marca.descripcion as marca, ",
                                      "        producto.cantidad,",
                                      "        producto.precio_venta",
                                      "        FROM Productos as producto",
                                      "  INNER JOIN Marcas as marca ON  marca.id_marca = producto.id_marca",
                                      " WHERE producto.borrado=0 ");

            strSql += sqlcondiciones;

            //sin parametros
            strSql += "ORDER BY producto.nombre DESC";

            var resultadoConsulta = (DataRowCollection)DBHelper.GetDBHelper().ConsultaSQL(strSql).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoProductos.Add(MappingProducto(row));
            }

            return listadoProductos;
        }





        private Producto MappingProducto(DataRow row)
        {
            Producto oProducto = new Producto();
            oProducto.IdProducto = Convert.ToInt32(row["id_producto"].ToString());
            oProducto.Nombre = row["nombre"].ToString();

            oProducto.Marca = new Marca();
            oProducto.Marca.IdMarca = Convert.ToInt32(row["id_marca"].ToString());
            oProducto.Marca.Descripcion = row["marca"].ToString();

            oProducto.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
            oProducto.Precio_Venta = Convert.ToInt32(row["precio_venta"].ToString());
           
            return oProducto;
        }
    }

}