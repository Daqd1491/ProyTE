using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    public class CambioContrasenna
    {
        [Required(ErrorMessage = "Contraseña requerida")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Contraseña actual")]
        public string passActual { get; set; }

        [Required(ErrorMessage = "Contraseña requerida")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Nueva contraseña")]
        public string passNuevo { get; set; }

        [Required(ErrorMessage = "Contraseña requerida")]
        [Compare("passNuevo", ErrorMessage = "La contraseña no coincide, ¡Escribe de nuevo!")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Confirmar nueva contraseña")]
        public string passConfirma { get; set; }
    }
}