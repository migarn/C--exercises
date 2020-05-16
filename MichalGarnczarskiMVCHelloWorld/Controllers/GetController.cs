using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MichalGarnczarskiMVCHelloWorld.Controllers
{
    public class GetController : Controller
    {
        public string Index(string name)
        {
            return "Hallo " + name + ", tu  metoda  Index GetControllera";
        }
    }
}