using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ASP.NET_Core_MVC_Sample.Controllers
{
    public class HelloWorldController : Controller
    {
        public String Index()
        {
            return "This is my default action...";
        }

        //public String Welcome()
        //{
        //    return "This is the Welcome action methd...";
        //}

        public string Welcome(String name, Int32 ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}