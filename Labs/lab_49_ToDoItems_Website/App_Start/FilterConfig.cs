﻿using System.Web;
using System.Web.Mvc;

namespace lab_49_ToDoItems_Website
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
