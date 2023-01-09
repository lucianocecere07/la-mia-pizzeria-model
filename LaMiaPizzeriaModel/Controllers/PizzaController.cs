﻿using LaMiaPizzeriaModel.Models;
using LaMiaPizzeriaModel.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace LaMiaPizzeriaModel.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> listaPizza = PizzeLista.Pizze();
            return View("Index", listaPizza);
        }

        public IActionResult Dettagli(int idScelto)
        {
            List<Pizza> listaPizza = PizzeLista.Pizze();
            foreach (Pizza pizza in listaPizza)
            {
                if (pizza.Id == idScelto)
                {
                    return View(pizza);
                }
            }

            return NotFound("Questa pizza non esiste");
        }
    }
}
