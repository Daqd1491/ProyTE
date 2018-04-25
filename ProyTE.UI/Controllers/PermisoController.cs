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
    public class PermisoController : Controller
    {
        IPermisos perm;

        public PermisoController()
        {
            perm = new MPermisos();
        }

        // GET: Permiso
        public ActionResult Index()
        {
            if (Session["UserEmail"] != null)
            {
                var lista = perm.ListarPermisos();
                var permisos = Mapper.Map<List<Models.TbPermisos>>(lista);
                return View(permisos);
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
        public ActionResult Create(Models.TbPermisos permiso)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbPermisos>(permiso);
                perm.InsertarPermiso(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            if (Session["UserEmail"] != null)
            {
                var permiso = perm.BuscarPermiso(id);
                var mostrar = Mapper.Map<Models.TbPermisos>(permiso);
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
                var permiso = perm.BuscarPermiso(id);
                var mostrar = Mapper.Map<Models.TbPermisos>(permiso);
                return View(mostrar);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbPermisos permiso)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbPermisos>(permiso);
                perm.ActualizarPermiso(modificar);
                return RedirectToAction("Index");
            }
            return View(permiso);
        }

        //delete
        public ActionResult Delete(int id)
        {
            if (Session["UserEmail"] != null)
            {
                perm.EliminarPermiso(id);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
    }
}