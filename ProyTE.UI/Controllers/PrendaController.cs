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
    public class PrendaController : Controller
    {
        IPrendas pren;

        public PrendaController()
        {
            pren = new MPrendas();
        }

        // GET: Prenda
        public ActionResult Index()
        {
            if (Session["UserEmail"] != null)
            {
                var lista = pren.ListarPrendas();
                var prendas = Mapper.Map<List<Models.TbPrendas>>(lista);
                return View(prendas);
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
        public ActionResult Create(Models.TbPrendas prenda)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbPrendas>(prenda);
                pren.InsertarPrenda(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            if (Session["UserEmail"] != null)
            {
                var prenda = pren.BuscarPrenda(id);
                var mostrar = Mapper.Map<Models.TbPrendas>(prenda);
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
                var prenda = pren.BuscarPrenda(id);
                var mostrar = Mapper.Map<Models.TbPrendas>(prenda);
                return View(mostrar);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbPrendas prenda)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbPrendas>(prenda);
                pren.ActualizarPrenda(modificar);
                return RedirectToAction("Index");
            }
            return View(prenda);
        }

        //delete
        public ActionResult Delete(int id)
        {
            if (Session["UserEmail"] != null)
            {
                pren.EliminarPrenda(id);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
    }
}