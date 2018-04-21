using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyTE.BLL.Metodos
{
    public class MBase
    {
        protected ProyTE.DAL.Interfaces.IAlquiler_Producto alqProd;
        protected ProyTE.DAL.Interfaces.IAlquileres alqui;
        public ProyTE.DAL.Interfaces.ICategorias cat;
        public ProyTE.DAL.Interfaces.IHistorial_Medidas histMed;
        public ProyTE.DAL.Interfaces.IPermisos permi;
        public ProyTE.DAL.Interfaces.IPrendas prend;
        public ProyTE.DAL.Interfaces.IProductos produc;
        public ProyTE.DAL.Interfaces.IRol_Permiso rolPermi;
        public ProyTE.DAL.Interfaces.IRoles rols;
        public ProyTE.DAL.Interfaces.ITarjetas tarj;
        public ProyTE.DAL.Interfaces.ITipo_Tarjetas tipTarj;
        public ProyTE.DAL.Interfaces.IUsuario_Tarjeta usuTarj;
        public ProyTE.DAL.Interfaces.IUsuarios usu;

        public MBase()
        {
            alqProd = new ProyTE.DAL.Metodos.MAlquiler_Producto();
            alqui = new ProyTE.DAL.Metodos.MAlquileres();
            cat = new ProyTE.DAL.Metodos.MCategorias();
            histMed = new ProyTE.DAL.Metodos.MHistorial_Medidas();
            permi = new ProyTE.DAL.Metodos.MPermisos();
            prend = new ProyTE.DAL.Metodos.MPrendas();
            produc = new ProyTE.DAL.Metodos.MProductos();
            rolPermi = new ProyTE.DAL.Metodos.MRol_Permiso();
            rols = new ProyTE.DAL.Metodos.MRoles();
            tarj = new ProyTE.DAL.Metodos.MTarjetas();
            tipTarj = new ProyTE.DAL.Metodos.MTipo_Tarjetas();
            usuTarj = new ProyTE.DAL.Metodos.MUsuario_Tarjeta();
            usu = new ProyTE.DAL.Metodos.MUsuarios();
        }

    }
}
