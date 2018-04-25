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
    public class RolController : Controller
    {
        IRoles ro;

        public RolController()
        {
            ro = new MRoles();
        }

        // GET: Rol
        public ActionResult Index()
        {
            if (Session["UserEmail"] != null)
            {
                var lista = ro.ListarRoles();
                var roles = Mapper.Map<List<Models.TbRoles>>(lista);
                return View(roles);
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
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        //insert
        [HttpPost]
        public ActionResult Create(Models.TbRoles rol)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbRoles>(rol);
                ro.InsertarRol(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            if (Session["UserEmail"] != null)
            {
                var rol = ro.BuscarRol(id);
                var mostrar = Mapper.Map<Models.TbRoles>(rol);
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
                var rol = ro.BuscarRol(id);
                var mostrar = Mapper.Map<Models.TbRoles>(rol);
                return View(mostrar);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbRoles rol)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbRoles>(rol);
                ro.ActualizarRol(modificar);
                return RedirectToAction("Index");
            }
            return View(rol);
        }

        //delete
        public ActionResult Delete(int id)
        {
            if (Session["UserEmail"] != null)
            {
                ro.EliminarRol(id);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
    }
}