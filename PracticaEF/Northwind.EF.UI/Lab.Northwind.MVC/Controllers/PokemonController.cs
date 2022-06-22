using Lab.Northwind.MVC.Models;
using Newtonsoft.Json;
using Northwind.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.Northwind.MVC.Controllers
{
    public class PokemonController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var logic = new PokemonLogic();
            var result = await logic.PokemonEevee();
            var eevee = JsonConvert.DeserializeObject<Pokemon>(result);
            return View(eevee);
        }
    }
}