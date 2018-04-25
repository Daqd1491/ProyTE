using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.BLL.Interfaces
{
    public interface ICuenta
    {
        // Login
        TbUsuarios Login(string correo);

        // Cambiar contraseña
        TbUsuarios BuscarUsuario(string correo);
    }
}
