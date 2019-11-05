using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AppRoute66
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Nome Aleatório",
                url: "noticias/{categoria}/{titulo}-{noticiaId}",
                defaults: new { Controller = "Home", action = "MostrarNoticia", id = UrlParameter.Optional },
                 namespaces: new[] { "AppRoute66.Controllers" }
                );

            routes.MapRoute(
                name: "Categoria Especifica",
                url: "noticias/{categoria}",
                defaults: new { Controller = "Home", action = "MostraCategoria", id = UrlParameter.Optional },
                 namespaces: new[] { "AppRoute66.Controllers" }
                );

            routes.MapRoute(
                name: "Todas as Noticias",
                url: "noticias/",
                defaults: new { Controller = "Home", action = "Noticia", id = UrlParameter.Optional },
                namespaces: new[] { "AppRoute66.Controllers" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { Controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "AppRoute66.Controllers" }
                );

            routes.MapRoute(
                 name: "HomeFinanceiro",
                 url: "{controller}/{action}/{id}",
                defaults: new { Controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "AppRoute66.Controllers" }
            );
            routes.MapRoute(
                 name: "Home",
                 url: "{controller}/{action}/{id}",
                defaults: new { Controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "AppRoute66.Controllers" }
            );

        }
    }
}
