using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dataset.Model;

namespace MVC.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Info(int id)
        {
            Client c = new Client() { FirstName = "Jan Novák" };

            ViewData["boss"] = "Petr Krátký";
            ViewData["date"] = DateTime.Now;       

            return View(c);
        }
    }
}
