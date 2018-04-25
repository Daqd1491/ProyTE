using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyTE.UI.Models;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;
using ProyTE.BLL.Metodos;
using AutoMapper;

namespace ProyTE.UI.Controllers
{
    public class UsuarioController : Controller
    {
        IUsuarios usua;
        IRoles ro;

        public UsuarioController()
        {
            usua = new MUsuarios();
            ro = new MRoles();
        }

        // GET: Usuario
        public ActionResult Index()
        {
            if (Session["UserEmail"] != null)
            {
                var lista = usua.ListarUsuarios();
                var usuarios = Mapper.Map<List<Models.TbUsuarios>>(lista);
                return View(usuarios);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        //vista insert
        public ActionResult Create()
        {
            if (Session["UserEmail"] != null)
            {
                var roles = ro.ListarRoles();
                ViewBag.ddlRoles = new SelectList(roles, "Id_Rol", "Nombre");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        //insert
        [HttpPost]
        public ActionResult Create(Models.TbUsuarios usuario)
        {
            if (ModelState.IsValid)
            {

                usuario.Id_Rol = Convert.ToInt32(Request.Form["ddlRoles"]);

                var insertar = Mapper.Map<DATA.TbUsuarios>(usuario);
                usua.InsertarUsuario(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            if (Session["UserEmail"] != null)
            {
                var usuario = usua.BuscarUsuario(id);
                var mostrar = Mapper.Map<Models.TbUsuarios>(usuario);
                return View(mostrar);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        //vista update
        public ActionResult Edit(int id)
        {
            if (Session["UserEmail"] != null)
            {
                var usuario = usua.BuscarUsuario(id);
                var mostrar = Mapper.Map<Models.TbUsuarios>(usuario);
                return View(mostrar);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbUsuarios usuario)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbUsuarios>(usuario);
                usua.ActualizarUsuario(modificar);
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        //delete
        public ActionResult Delete(int id)
        {
            if (Session["UserEmail"] != null)
            {
                usua.EliminarUsuario(id);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
         
    }
}
 