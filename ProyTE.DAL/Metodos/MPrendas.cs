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
    public class MPrendas : MBase, IPrendas
    {
        public void ActualizarPrenda(TbPrendas prenda)
        {
            _db = _conexion.Open();
            _db.Update(prenda);
            _db.Close();
        }

        public TbPrendas BuscarPrenda(int idPrenda)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbPrendas>(x => x.Id_Prenda == idPrenda).FirstOrDefault();
            _db.Close();
            return select;
        }

        public void EliminarPrenda(int idPrenda)
        {
            _db = _conexion.Open();
            _db.Delete<TbPrendas>(x => x.Id_Prenda == idPrenda);
            _db.Close();
        }

        public void InsertarPrenda(TbPrendas prenda)
        {
            _db = _conexion.Open();
            _db.Insert(prenda);
            _db.Close();
        }

        public List<TbPrendas> ListarPrendas()
        {
            _db = _conexion.Open();
            var select = _db.Select<TbPrendas>();
            _db.Close();
            return select;
        }
    }
}
