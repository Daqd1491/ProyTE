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
    public class MRol_Permiso : MBase, IRol_Permiso
    {
        public void ActualizarRol_Permiso(TbRol_Permiso rol_permiso)
        {
            _db = _conexion.Open();
            _db.Update(rol_permiso);
            _db.Close();
        }

        public TbRol_Permiso BuscarRol_Permiso(int idRol_Permiso)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbRol_Permiso>(x => x.Id_Rol_Permiso == idRol_Permiso).FirstOrDefault();
            _db.Close();
            return select;
        }

        public void EliminarRol_Permiso(int idRol_Permiso)
        {
            _db = _conexion.Open();
            _db.Delete<TbRol_Permiso>(x => x.Id_Rol_Permiso == idRol_Permiso);
            _db.Close();
        }

        public void InsertarRol_Permiso(TbRol_Permiso rol_permiso)
        {
            _db = _conexion.Open();
            _db.Insert(rol_permiso);
            _db.Close();
        }

        public List<TbRol_Permiso> ListarRol_Permisos()
        {
            _db = _conexion.Open();
            var select = _db.Select<TbRol_Permiso>();
            _db.Close();
            return select;
        }
    }
}
