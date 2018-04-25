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
    public class MAlquiler_Producto : MBase, IAlquiler_Producto
    {
        public void ActualizarAlquiler_Producto(TbAlquiler_Producto alquilerProducto)
        {
            _db = _conexion.Open();
            _db.Update(alquilerProducto);
            _db.Close();
        }

        public TbAlquiler_Producto BuscarAlquiler_Producto(int idAlquiler_Producto)
        {
            _db = _conexion.Open();
             var select = _db.Select<TbAlquiler_Producto>(x => x.Id_Alquiler_Producto == idAlquiler_Producto).FirstOrDefault();
            _db.Close();
            return select;
        }

        public void EliminarAlquiler_Producto(int idAlquiler_Producto)
        {
            _db = _conexion.Open();
            _db.Delete<TbAlquiler_Producto>(x => x.Id_Alquiler_Producto == idAlquiler_Producto);
            _db.Close();
        }

        public void InsertarAlquiler_Producto(TbAlquiler_Producto alquilerProducto)
        {
            _db = _conexion.Open();
            _db.Insert(alquilerProducto);
            _db.Close();
        }

        public List<TbAlquiler_Producto> ListarAlquiler_Producto()
        {
            _db = _conexion.Open();
            var select = _db.Select<TbAlquiler_Producto>();
            _db.Close();
            return select;
        }
    }
}
