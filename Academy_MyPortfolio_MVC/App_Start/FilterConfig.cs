﻿using System.Web;
using System.Web.Mvc;

namespace Academy_MyPortfolio_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
