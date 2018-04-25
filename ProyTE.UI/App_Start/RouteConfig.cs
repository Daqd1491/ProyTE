using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProyTE.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //Ruta Cambio Contrasenna
            routes.MapRoute(
                name: "CambioContrasenna",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Login",
                    action = "CambioContrasenna",
                    id = UrlParameter.Optional
                }
            );

            //Ruta Login
            routes.MapRoute(
                name: "Login",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Login",
                    action = "Login",
                    id = UrlParameter.Optional
                }
            );

            //Ruta Usuario
            routes.MapRoute(
                name: "Usuario",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Usuario",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            //Ruta Alquiler
            routes.MapRoute(
                name: "Alquiler",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Alquiler",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            //Ruta Historial_Medida
            routes.MapRoute(
                name: "Historial_Medida",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Historial_Medida",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            //Ruta Permiso
            routes.MapRoute(
                name: "Permiso",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Permiso",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            //Ruta Prenda
            routes.MapRoute(
                name: "Prenda",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Prenda",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            //Ruta Producto
            routes.MapRoute(
                name: "Producto",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Producto",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            //Ruta Rol
            routes.MapRoute(
                name: "Rol",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Rol",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            //Ruta Tarjeta
            routes.MapRoute(
                name: "Tarjeta",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Tarjeta",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            //Ruta Tipo_Tarjeta
            routes.MapRoute(
                name: "Tipo_Tarjeta",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Tipo_Tarjeta",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}
