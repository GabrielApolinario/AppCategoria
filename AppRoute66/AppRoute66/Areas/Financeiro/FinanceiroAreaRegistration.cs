﻿using System.Web.Mvc;

namespace AppRoute66.Areas.Financeiro
{
    public class FinanceiroAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Financeiro";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Financeiro_default",
                "Financeiro/{controller}/{action}/{id}",
                new { Controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}