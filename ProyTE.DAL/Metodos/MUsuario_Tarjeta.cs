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
    public class MUsuario_Tarjeta : MBase, IUsuario_Tarjeta
    {
        public void ActualizarUsuario_Tarjeta(TbUsuario_Tarjeta usuarioTarjeta)
        {
            _db = _conexion.Open();
            _db.Update(usuarioTarjeta);
            _db.Close();
        }

        public TbUsuario_Tarjeta BuscarUsuario_Tarjeta(int idUsuario_Tarjeta)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbUsuario_Tarjeta>(x => x.Id_Usuario_Tarjeta == idUsuario_Tarjeta).FirstOrDefault();
            _db.Close();
            return select;
        }

        public void EliminarUsuario_Tarjeta(int idUsuario_Tarjeta)
        {
            _db = _conexion.Open();
            _db.Delete<TbUsuario_Tarjeta>(x => x.Id_Usuario_Tarjeta == idUsuario_Tarjeta);
            _db.Close();
        }

        public void InsertarUsuario_Tarjeta(TbUsuario_Tarjeta usuarioTarjeta)
        {
            _db = _conexion.Open();
            _db.Insert(usuarioTarjeta);
            _db.Close();
        }

        public List<TbUsuario_Tarjeta> ListarUsuario_Tarjetas()
        {
            _db = _conexion.Open();
            var select = _db.Select<TbUsuario_Tarjeta>();
            _db.Close();
            return select;
        }
    }
}
