using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;
using ProyTE.BLL;

namespace ProyTE.BLL.Metodos
{
    public class MUsuarios : MBase, IUsuarios
    {
        public void ActualizarUsuario(TbUsuarios usuario)
        {
            usu.ActualizarUsuario(usuario);
        }

        public TbUsuarios BuscarUsuario(int idUsuario)
        {
            return usu.BuscarUsuario(idUsuario);
        }

        public void EliminarUsuario(int idUsuario)
        {
            usu.EliminarUsuario(idUsuario);
        }

        public void InsertarUsuario(TbUsuarios usuario)
        {
            TbUsuarios user = new TbUsuarios
            {
                Id_Usuario = usuario.Id_Usuario,
                Id_Rol = usuario.Id_Rol,
                Cedula = usuario.Cedula,
                Nombre = usuario.Nombre,
                Apellido_1 = usuario.Apellido_1,
                Apellido_2 = usuario.Apellido_2,
                Telefono_1 = usuario.Telefono_1,
                Telefono_2 = usuario.Telefono_2,
                Correo = usuario.Correo,
                NombreUsuario = usuario.NombreUsuario,
                Contrasenna = Utilidades.Encriptar(usuario.Contrasenna),
                Foto = usuario.Foto
            };
            usu.InsertarUsuario(user);
        }

        public List<TbUsuarios> ListarUsuarios()
        {
            return usu.ListarUsuarios();
        }
    }
}
