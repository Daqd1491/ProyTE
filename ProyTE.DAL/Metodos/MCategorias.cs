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
    public class MCategorias : MBase, ICategorias
    {
        public void ActualizarCategoria(TbCategorias categoria)
        {
            _db = _conexion.Open();
            _db.Update(categoria);
            _db.Close();
        }

        public TbCategorias BuscarCategoria(int idCategoria)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbCategorias>(x => x.Id_Categoria == idCategoria).FirstOrDefault();
            _db.Close();
            return select;
        }

        public void EliminarCategoria(int idCategoria)
        {
            _db = _conexion.Open();
            _db.Delete<TbCategorias>(x => x.Id_Categoria == idCategoria);
            _db.Close();
        }

        public void InsertarCategoria(TbCategorias categoria)
        {
            _db = _conexion.Open();
            _db.Insert(categoria);
            _db.Close();
        }

        public List<TbCategorias> ListarCategorias()
        {
            _db = _conexion.Open();
            var select = _db.Select<TbCategorias>();
            _db.Close();
            return select;
        }
    }
}
