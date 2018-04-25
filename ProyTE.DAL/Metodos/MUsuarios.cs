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
    public class MUsuarios : MBase, IUsuarios
    {
        public void ActualizarUsuario(TbUsuarios usuario)
        {
            _db = _conexion.Open();
            _db.Update(usuario);
            _db.Close();
        }

        public TbUsuarios BuscarUsuario(int idUsuario)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbUsuarios>(x => x.Id_Usuario == idUsuario).FirstOrDefault();
            _db.Close();
            return select;
        }

        public void EliminarUsuario(int idUsuario)
        {
            _db = _conexion.Open();
            _db.Delete<TbUsuarios>(x => x.Id_Usuario == idUsuario);
            _db.Close();

        }

        public void InsertarUsuario(TbUsuarios usuario)
        {
            _db = _conexion.Open();
            _db.Insert(usuario);
            _db.Close();

        }

        public List<TbUsuarios> ListarUsuarios()
        {
            _db = _conexion.Open();
            var select = _db.Select<TbUsuarios>();
            _db.Close();
            return select;
        }
    }
}
