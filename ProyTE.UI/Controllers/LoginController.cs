using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;
using ProyTE.BLL.Metodos;
using AutoMapper;
using ProyTE.UI.Models;
using ProyTE.BLL;

namespace ProyTE.UI.Controllers
{
    public class LoginController : Controller
    {
        ICuenta cuent;
        IUsuarios usua;

        public LoginController()
        {
            cuent = new MCuenta();
            usua = new MUsuarios();
        }

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.Login user)
        {
            if (ModelState.IsValid)
            {
                var usuario = cuent.Login(user.mail);
                var pass = Utilidades.Decriptar(usuario.Contrasenna);
                if (user.password == pass)
                {
                    //Guardamos session, ingresamos al sistema
                    Session["UserEmail"] = usuario.Correo.ToString();
                    Session["UserName"] = usuario.Nombre.ToString();
                    return RedirectToAction("Index", "Alquiler");
                }
                else
                {
                    //Mensaje contraseña no valido y limpio contraseña
                    return View();
                }
            }
            return View();
        }

        //Cerrar sesión
        public ActionResult Terminar()
        {
            Session.Clear();
            return RedirectToAction("Login", "Login");
        }

        // ACtualizar contraseña
        public ActionResult CambioContrasenna()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CambioContrasenna(Models.CambioContrasenna password)
        {
            if (ModelState.IsValid)
            {
                var usuario = cuent.BuscarUsuario(Session["UserEmail"].ToString());

                if (Utilidades.Decriptar(usuario.Contrasenna) == password.passActual)
                {
                    Models.TbUsuarios us = new Models.TbUsuarios
                    {
                        Id_Usuario = usuario.Id_Usuario,
                        Id_Rol = usuario.Id_Rol,
                        Cedula = usuario.Cedula,
                        Nombre = usuario.Nombre,
                        Apellido_1 = usuario.Apellido_1,
                        Apellido_2 = usuario.Apellido_2,
                        Telefono_1 = usuario.Telefono_1,
                        Telefono_2 = usuario.Telefono_2,
                        Correo = usuario.Correo,
                        NombreUsuario = usuario.NombreUsuario,
                        Contrasenna = Utilidades.Encriptar(password.passNuevo),
                        Foto = usuario.Foto
                    };
                    var modificar = Mapper.Map<DATA.TbUsuarios>(us);
                    usua.ActualizarUsuario(modificar);
                    Terminar();
                    //Mensaje: "Su contraseña ha sido actualizada" cerrar sesion y a diregir a pantalla login. (Opcional, Notificar al correo cambio de contraseña)
                }
                else
                {
                    //Mensaje: "Ingrese una contraseña valida", limpiar y diriguir al campo passActual
                }
                return RedirectToAction("Login", "Login");
            }
            return View(password);
        }

        
    }
}