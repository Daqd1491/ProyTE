using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.DAL.Interfaces
{
    public interface IAlquiler_Producto
    {
        // Select *
        List<TbAlquiler_Producto> ListarAlquiler_Producto();
        // Select por PK
        TbAlquiler_Producto BuscarAlquiler_Producto(int idAlquiler_Producto);
        // Insert
        void InsertarAlquiler_Producto(TbAlquiler_Producto alquilerProducto);
        // Update
        void ActualizarAlquiler_Producto(TbAlquiler_Producto alquilerProducto);
        // Delete
        void EliminarAlquiler_Producto(int idAlquiler_Producto);
        
    }
}
