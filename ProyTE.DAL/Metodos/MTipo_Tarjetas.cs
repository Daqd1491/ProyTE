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
    public class MTipo_Tarjetas : MBase, ITipo_Tarjetas
    {
        public void ActualizarTipo_Tarjeta(TbTipo_Tarjetas tipoTarjeta)
        {
            _db = _conexion.Open();
            _db.Update(tipoTarjeta);
            _db.Close();
        }

        public TbTipo_Tarjetas BuscarTipo_Tarjeta(int idTipo_Tarjeta)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbTipo_Tarjetas>(x => x.Id_TipoTarjeta == idTipo_Tarjeta).FirstOrDefault();
            _db.Close();
            return select;
        }

        public void EliminarTipo_Tarjeta(int idTipo_Tarjeta)
        {
            _db = _conexion.Open();
            _db.Delete<TbTipo_Tarjetas>(x => x.Id_TipoTarjeta == idTipo_Tarjeta);
            _db.Close();
        }

        public void InsertarTipo_Tarjeta(TbTipo_Tarjetas tipoTarjeta)
        {
            _db = _conexion.Open();
            _db.Insert(tipoTarjeta);
            _db.Close();
        }

        public List<TbTipo_Tarjetas> ListarTipo_Tarjetas()
        {
            _db = _conexion.Open();
            var selcet = _db.Select<TbTipo_Tarjetas>();
            _db.Close();
            return selcet;
        }
    }
}
