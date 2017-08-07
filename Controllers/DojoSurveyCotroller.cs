using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers
{
    public class DojoSurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
            
        }
        [HttpPost]
        [Route("result")]
        public IActionResult Result(string name, string Location, string Language, string comments)
        {

            ViewBag.Name = name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = comments;
            return View();
            
        }
    }
}
