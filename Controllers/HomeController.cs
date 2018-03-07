using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Mensagem = "Teste";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descrição para a página da sua aplicação.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sua página de contato.";

            return View();
        }
    }
}