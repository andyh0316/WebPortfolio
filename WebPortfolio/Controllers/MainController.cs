using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPortfolio.Models;

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
            Media media = new Media
            {
                MediaContents = new List<MediaContent>()
            };

            media.MediaContents.Add(
                new MediaContent {
                    ImageSrc = "/Content/Redesign/Facilities1.png",
                    DescriptionTitle = "Before Redesign",
                    Description = "The colors of the design are too plain; it is mainly different shades of gray that do not make a good complementary design. "
                    + "The color red is a bad choice since it represents errors. There are also too many sections within sections that leads to inefficient spacing."
                    + "The data in the table are too tight together. "
                }    
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/Facilities2.png",
                    DescriptionTitle = "After Redesign",
                    Description = "I chose the colors light black, light blue and white as complementary background colors that separates the three largest areas of the application."
                    + "I also removed the unnecessary nestings of sections that gives better spacing. I gave the overall application more spacing and more sharp colors for emphasis"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/Login1.jpg"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/Login2.png"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/PatientAccountLedger1.png"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/PatientAccountLedger2.png"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/PatientSearch1.png"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/PatientSearch2.png"
                }
            );

            return View(media);
        }
    }
}
