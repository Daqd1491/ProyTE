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
    public class MCuenta : MBase, ICuenta
    {
        public TbUsuarios Login(string correo)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbUsuarios>(x => x.Correo == correo).FirstOrDefault();
            _db.Dispose();
            return select;
        }

        public TbUsuarios BuscarUsuario(string correo)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbUsuarios>(x => x.Correo == correo).FirstOrDefault();
            _db.Close();
            return select;
        }
    }
}
