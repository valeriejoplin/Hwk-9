﻿using System.Web;
using System.Web.Mvc;

namespace IMDB_Ratings
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
