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
    public class TarjetaController : Controller
    {
        ITarjetas tar;

        public TarjetaController()
        {
            tar = new MTarjetas();
        }

        // GET: Tarjeta
        public ActionResult Index()
        {
            if (Session["UserEmail"] != null)
            {
                var lista = tar.ListarTarjetas();
                var tarjetas = Mapper.Map<List<Models.TbTarjetas>>(lista);
                return View(tarjetas);
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
        public ActionResult Create(Models.TbTarjetas tarjeta)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbTarjetas>(tarjeta);
                tar.InsertarTarjeta(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            if (Session["UserEmail"] != null)
            {
                var tarjeta = tar.BuscarTarjeta(id);
                var mostrar = Mapper.Map<Models.TbTarjetas>(tarjeta);
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
                var tarjeta = tar.BuscarTarjeta(id);
                var mostrar = Mapper.Map<Models.TbTarjetas>(tarjeta);
                return View(mostrar);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbTarjetas tarjeta)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbTarjetas>(tarjeta);
                tar.ActualizarTarjeta(modificar);
                return RedirectToAction("Index");
            }
            return View(tarjeta);
        }

        //delete
        public ActionResult Delete(int id)
        {
            if (Session["UserEmail"] != null)
            {
                tar.EliminarTarjeta(id);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
    }
}