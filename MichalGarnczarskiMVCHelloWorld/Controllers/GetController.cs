using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MichalGarnczarskiMVCHelloWorld.Controllers
{
    public class GetController : Controller
    {
        public IActionResult Index(string name)
        {
            return View();
            //return System.Web.HttpUtility.HtmlEncode("Hallo " + name + ", tu  metoda  Index GetControllera");
        }
    }
}