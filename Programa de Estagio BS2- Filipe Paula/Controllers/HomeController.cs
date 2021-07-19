using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Programa_de_Estagio_BS2__Filipe_Paula.Models;

namespace Programa_de_Estagio_BS2__Filipe_Paula
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
             return View();
        }
        public IActionResult Clientes()
        {

            return View( Cliente.Todos());
        }
    }
}
