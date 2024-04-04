using AspNet.DINNER.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.DINNER.Controllers
{
    public class DinnerController : Controller
    {
        public DinnerServices _dinnerServices;

        public DinnerController(DinnerServices dinnerServices)
        {
            _dinnerServices = dinnerServices;
        }

        [HttpGet]
        public IActionResult Dinner()
        {
            var vecere = _dinnerServices.vecere;
            return View(vecere);
        }
    }
}
