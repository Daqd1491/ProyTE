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
    public class MHistorial_Medidas : MBase, IHistorial_Medidas
    {
        public void ActualizarHistorial_Medidas(TbHistorial_Medidas historial_medida)
        {
            _db = _conexion.Open();
            _db.Update(historial_medida);
            _db.Close();
        }

        public TbHistorial_Medidas BuscarHistorial_Medida(int idHistorial_Medida)
        {
            _db = _conexion.Open();
            var select = _db.Select<TbHistorial_Medidas>(x => x.Id_HistorialMedidas == idHistorial_Medida).FirstOrDefault();
            _db.Close();
            return select;
        }

        public void EliminarHistorial_Medida(int idHistorial_Medida)
        {
            _db = _conexion.Open();
            _db.Delete<TbHistorial_Medidas>(x => x.Id_HistorialMedidas == idHistorial_Medida);
            _db.Close();
        }

        public void InsertarHistorial_Medida(TbHistorial_Medidas historial_medida)
        {
            _db = _conexion.Open();
            _db.Insert(historial_medida);
            _db.Close();
        }

        public List<TbHistorial_Medidas> ListarHistorial_Medidas()
        {
            _db = _conexion.Open();
            var select = _db.Select<TbHistorial_Medidas>();
            _db.Close();
            return select;
        }
    }
}
