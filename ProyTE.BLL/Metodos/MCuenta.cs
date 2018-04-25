using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MCuenta : MBase, ICuenta
    {
        public TbUsuarios Login(string correo)
        {
            return cuent.Login(correo);
        }

        public TbUsuarios BuscarUsuario(string correo)
        {
            return cuent.BuscarUsuario(correo);
        }
    }
}
