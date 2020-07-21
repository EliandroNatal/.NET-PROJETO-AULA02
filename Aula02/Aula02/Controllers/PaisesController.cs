using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aula02.Models;

namespace Aula02.Controllers
{
    public class PaisesController : Controller
    {
        public IActionResult Index()
        {
            List<Pais> list = new List<Pais>();
            list.Add(new Pais { Id = 1, Name = "Tanzania" });
            list.Add(new Pais { Id = 2, Name = "Namibia" });
           
            return View(list);
        }
    }
}
