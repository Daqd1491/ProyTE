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
    public class MAlquileres : MBase, IAlquileres
    {
        public void ActualizarAlquiler(TbAlquileres alquiler)
        {
            _db = _conexion.Open();
            _db.Update(alquiler);
            _db.Close();
        }

        public TbAlquileres BuscarAlquiler(int idAlquiler)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbAlquileres>(x => x.Id_Alquiler == idAlquiler).FirstOrDefault();
            _db.Close();
            return select;
        }

        public void EliminarAlquiler(int idAlquiler)
        {
            _db = _conexion.Open();
            _db.Delete<TbAlquileres>(x => x.Id_Alquiler == idAlquiler);
            _db.Close();
        }

        public void InsertarAlquiler(TbAlquileres alquiler)
        {
            _db = _conexion.Open();
            _db.Insert(alquiler);
            _db.Close();
        }

        public List<TbAlquileres> ListarAlquileres()
        {
            _db = _conexion.Open();
            var select = _db.Select<TbAlquileres>();
            _db.Close();
            return select;
        }
    }
}
