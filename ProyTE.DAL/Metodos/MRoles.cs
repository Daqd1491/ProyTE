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
    public class MRoles : MBase, IRoles
    {
        public void ActualizarRol(TbRoles rol)
        {
            _db = _conexion.Open();
            _db.Update(rol);
            _db.Close();
        }

        public TbRoles BuscarRol(int idRol)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbRoles>(x => x.Id_Rol == idRol).FirstOrDefault();
            _db.Close();
            return select;
        }

        public void EliminarRol(int idRol)
        {
            _db = _conexion.Open();
            _db.Delete<TbRoles>(x => x.Id_Rol == idRol);
            _db.Close();
        }

        public void InsertarRol(TbRoles rol)
        {
            _db = _conexion.Open();
            _db.Insert(rol);
            _db.Close();
        }

        public List<TbRoles> ListarRoles()
        {
            _db = _conexion.Open();
            var select = _db.Select<TbRoles>();
            _db.Close();
            return select;
        }
    }
}
