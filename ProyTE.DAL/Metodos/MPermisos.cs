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
    public class MPermisos : MBase, IPermisos
    {
        public void ActualizarPermiso(TbPermisos permiso)
        {
            _db = _conexion.Open();
            _db.Update(permiso);
            _db.Close();
        }

        public TbPermisos BuscarPermiso(int idPermiso)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbPermisos>(x => x.Id_Permiso == idPermiso).FirstOrDefault();
            _db.Close();
            return select;
        }

        public void EliminarPermiso(int idPermiso)
        {
            _db = _conexion.Open();
            _db.Delete<TbPermisos>(x => x.Id_Permiso == idPermiso);
            _db.Close();
        }

        public void InsertarPermiso(TbPermisos permiso)
        {
            _db = _conexion.Open();
            _db.Insert(permiso);
            _db.Close();
        }

        public List<TbPermisos> ListarPermisos()
        {
            _db = _conexion.Open();
            var select = _db.Select<TbPermisos>();
            _db.Close();
            return select;
        }
    }
}
