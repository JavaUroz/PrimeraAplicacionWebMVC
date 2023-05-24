using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text.Encodings.Web;
using PrimeraAplicacionWebMVC.Models;

namespace PrimeraAplicacionWebMVC.Controllers
{
    public class HolaMundoController : Controller
    {
        public IActionResult Index()
        {
            Empleado empleado = new Empleado();
            {
                empleado.Id = 1;
                empleado.Nombre = "Javier Uroz";
                empleado.Salario = 10;
            }
            return View(empleado);
        }
    }
}
