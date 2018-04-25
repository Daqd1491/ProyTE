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
    public class ProductoController : Controller
    {
        IProductos prod;

        public ProductoController()
        {
            prod = new MProductos();
        }

        // GET: Producto
        public ActionResult Index()
        {
            if (Session["UserEmail"] != null)
            {
                var lista = prod.ListarProductos();
                var productos = Mapper.Map<List<Models.TbProductos>>(lista);
                return View(productos);
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
        public ActionResult Create(Models.TbProductos producto)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbProductos>(producto);
                prod.InsertarProducto(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            if (Session["UserEmail"] != null)
            {
                var producto = prod.BuscarProducto(id);
                var mostrar = Mapper.Map<Models.TbProductos>(producto);
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
                var producto = prod.BuscarProducto(id);
                var mostrar = Mapper.Map<Models.TbProductos>(producto);
                return View(mostrar);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbProductos producto)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbProductos>(producto);
                prod.ActualizarProducto(modificar);
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        //delete
        public ActionResult Delete(int id)
        {
            if (Session["UserEmail"] != null)
            {
                prod.EliminarProducto(id);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
    }
}