using Actividad5.DAL;
using Actividad5.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.BSS
{
    public class ProductoBSS
    {
        ProductoDAL dal = new ProductoDAL();
        public DataTable ListarProductoBss()
        {
            return dal.ListarProductoDal();
        }
        public Producto ObtenerProductoIdBss(int id)
        {
            return dal.ObtenerProductoIdDal(id);
        }
    }
}
