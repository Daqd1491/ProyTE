using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //tarjetas de los usuarios para los alquileres
    public class TbTarjetas
    {
        public int Id_Tarjeta { get; set; }

        public int Id_TipoTarjeta { get; set; }

        [Required(ErrorMessage = "Nombre de la tarjeta requerida")]
        [StringLength(190, ErrorMessage = "Maximo 100 caracteres")]
        public string NombreTarjeta { get; set; }

        [Required(ErrorMessage = "Numero de Tarjeta requerido")]
        [CreditCard]
        public decimal NumTarjeta { get; set; }

        [Required(ErrorMessage = "Fecha de vencimiento requerida")]
        //Datetime Picker
        public DateTime FechaVencimiento { get; set; }
    }
}