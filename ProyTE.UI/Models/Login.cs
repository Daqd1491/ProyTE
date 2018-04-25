using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Correo requerido")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [EmailAddress(ErrorMessage = "Correo no valido")]
        [Display(Name = "Correo electrónico")]
        public string mail { get; set; }
        [Required(ErrorMessage = "Contraseña requerida")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Contraseña")]
        public string password { get; set; }
    }
}