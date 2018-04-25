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
    public class MTarjetas : MBase, ITarjetas
    {
        public void ActualizarTarjeta(TbTarjetas tarjeta)
        {
            _db = _conexion.Open();
            _db.Update(tarjeta);
            _db.Close();
        }

        public TbTarjetas BuscarTarjeta(int idTarjeta)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbTarjetas>(x => x.Id_Tarjeta == idTarjeta).FirstOrDefault();
            _db.Close();
            return select;
        }

        public void EliminarTarjeta(int idTarjeta)
        {
            _db = _conexion.Open();
            _db.Delete<TbTarjetas>(x => x.Id_Tarjeta == idTarjeta);
            _db.Close();
        }

        public void InsertarTarjeta(TbTarjetas tarjeta)
        {
            _db = _conexion.Open();
            _db.Insert(tarjeta);
            _db.Close();
        }

        public List<TbTarjetas> ListarTarjetas()
        {
            _db = _conexion.Open();
            var select = _db.Select<TbTarjetas>();
            _db.Close();
            return select;
        }
    }
}
