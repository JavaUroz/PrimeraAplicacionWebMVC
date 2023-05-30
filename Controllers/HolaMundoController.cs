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
                empleado.Nombre = "Roberto";
                empleado.Apellido = "Perez";
                empleado.Telefono = "(02473) 15 454545";
                empleado.Email = "r.perez@email.com.ar";
                empleado.Direccion = "Av. Pte. Irigoyen 1955";
                empleado.Cuil = "20-22222222-5";
				empleado.Salario = 100000;
            }
            return View(empleado);
        }
    }
}
