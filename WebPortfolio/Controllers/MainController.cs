using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPortfolio.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.IsHtml = true;
            return View();
        }

        public ActionResult ResumePdfAction()
        {
            return View("Resume");
        }

        public ActionResult ResumePdf()
        {
            return new Rotativa.ActionAsPdf("ResumePdfAction")
                    {
                        PageOrientation = Rotativa.Options.Orientation.Portrait,
                        PageSize = Rotativa.Options.Size.A4,
                        PageMargins = new Rotativa.Options.Margins(0, 0, 0, 0)
                    };
        }

        public ActionResult JBabyUsa()
        {
            return View("/Views/Jbabyusa/Index.cshtml");
        }

        public ActionResult Redesign()
        {
            return View();
        }
    }
}
