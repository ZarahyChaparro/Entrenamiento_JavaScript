using Microsoft.AspNetCore.Mvc;
using Proyecto_JavaScript.Models;
using System.Diagnostics;

namespace Proyecto_JavaScript.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> BuscarLibros(string consulta)
        {
            using (var httpClient = new HttpClient())
            {
                var apiUrl = $"https://www.googleapis.com/books/v1/volumes?q={consulta}";
                var response = await httpClient.GetStringAsync(apiUrl);
                return Json(response);
            }
        }
    }
}



