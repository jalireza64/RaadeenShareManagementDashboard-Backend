﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeRequest.Infrastracture.ViewEngins
{
    public class CustomViewEngine : RazorViewEngine
    {
        public CustomViewEngine()
        {
            var viewLocations = new[] {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml",
                "~/Views/Shared/ErrorHandler/{0}.cshtml"
                // etc
            };
            this.PartialViewLocationFormats = viewLocations;
            this.ViewLocationFormats = viewLocations;
        }

    }
}