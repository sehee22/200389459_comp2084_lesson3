﻿using System.Web;
using System.Web.Mvc;

namespace _200389459_comp2084_lesson3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
