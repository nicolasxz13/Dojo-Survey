using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class DojoSurvey : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(string Iname, string Ilocation, string Ifavorite, string Icomment)
        {
            ViewBag.Iname = Iname;
            ViewBag.Ilocation = Ilocation;
            ViewBag.Ifavorite = Ifavorite;
            ViewBag.IComment = Icomment;
            return View();
        }
    }
}
