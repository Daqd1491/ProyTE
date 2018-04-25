using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.DAL.Interfaces;
using System.Data;
using ServiceStack.OrmLite;

namespace ProyTE.DAL.Metodos
{
    public class MProductos : MBase, IProductos
    {
        public void ActualizarProducto(TbProductos producto)
        {
            _db = _conexion.Open();
            _db.Update(producto);
            _db.Close();
        }

        public TbProductos BuscarProducto(int idProducto)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbProductos>(x => x.Id_Producto == idProducto).FirstOrDefault();
            _db.Close();
            return select;
        }

        public void EliminarProducto(int idProducto)
        {
            _db = _conexion.Open();
            _db.Delete<TbProductos>(x => x.Id_Producto == idProducto);
            _db.Close();
        }

        public void InsertarProducto(TbProductos producto)
        {
            _db = _conexion.Open();
            _db.Insert(producto);
            _db.Close();
        }

        public List<TbProductos> ListarProductos()
        {
            _db = _conexion.Open();
            var select = _db.Select<TbProductos>();
            _db.Close();
            return select;
        }

        public List<ViewProducto> ListarVProductos()
        {
            _db = _conexion.Open();
            var select = _db.SqlList<ViewProducto>("EXEC sp_VerProductos");
            _db.Close();
            return select;
        }
    }
}
