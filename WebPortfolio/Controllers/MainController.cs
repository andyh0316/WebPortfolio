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
                    DescriptionTitle = "Before Redesign: Application",
                    DescriptionClass = "red",
                    Description = "The colors of the design are too plain; it is mainly different shades of gray that do not make a good complementary design. "
                    + "The color red is a bad choice since it represents errors. There are also too many sections within sections that leads to inefficient spacing. "
                    + "The data in the table are too tight together. "
                }    
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/Facilities2.png",
                    DescriptionTitle = "After Redesign: Application",
                    DescriptionClass = "green",
                    Description = "I chose the colors light black, light blue and white as complementary background colors that separates the three largest areas of the application. "
                    + "I also removed the unnecessary nestings of sections that gives better spacing. I gave the overall application more spacing and more sharp colors for emphasis. "
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/Login1.jpg",
                    DescriptionTitle = "Before Redesign: Login",
                    DescriptionClass = "red",
                    Description = "The users sees the login screen everyday, they don't need to see the Labels 'Practice Account #', "
                    + "'User Name' and 'Password' repeatedly. And the gradient is old school like the 90s."
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/Login2.png",
                    DescriptionTitle = "After Redesign: Login",
                    DescriptionClass = "green",
                    Description = "Looks a little bit more aesthetically pleasing. The labels are replaced by the icons which should be intuitive enough. "
                    + "Also, the textbox sizes are enlarged for clickers to click more easily."
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/PatientAccountLedger1.png",
                    DescriptionTitle = "Before Redesign: Patient Information",
                    DescriptionClass = "red",
                    Description = "The patient header information are a bunch of flat text that doesn't emphasize information by importance."
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/PatientAccountLedger2.png",
                    DescriptionTitle = "After Redesign: Patient Information",
                    DescriptionClass = "green",
                    Description = "The patient header information are emphasized in order of importance by font, boldness, and color. "
                    + "The labels are deemphasized with small font and color because they become less important as users become more familiar. "
                    + "Some labels are removed because the contents are self-explanatory"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/PatientSearch1.png",
                    DescriptionTitle = "Before Redesign: Patient Search",
                    DescriptionClass = "red",
                    Description = "This is just plain ugly."
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/PatientSearch2.png",
                    DescriptionTitle = "After Redesign: Patient Search",
                    DescriptionClass = "green"
                }
            );

            return View(media);
        }

        public ActionResult Photography()
        {
            Media media = new Media
            {
                MediaContents = new List<MediaContent>()
            };

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Photography/IMG_4003.jpg",
                    DescriptionTitle = "Ceiling Flashlight"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Photography/IMG_5639.jpg",
                    DescriptionTitle = "Las Vegas: Long Exposure"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Photography/IMG_5640.jpg",
                    DescriptionTitle = "Las Vegas: Long Exposure"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Photography/IMG_7142.jpg",
                    DescriptionTitle = "Fast Shutter High Aperture"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Photography/IMG_7409.jpg",
                    DescriptionTitle = "High Aperture"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Photography/IMG_7450.jpg",
                    DescriptionTitle = "Sydney: Normalized Exposure"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Photography/IMG_7452.jpg",
                    DescriptionTitle = "Sydney: Extreme Normalized Exposure"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Photography/IMG_7900.jpg",
                    DescriptionTitle = "San Diego: Long Exposure"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Photography/IMG_8380.jpg",
                    DescriptionTitle = "Yeah.... I don't know"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Photography/IMG_8389.jpg",
                    DescriptionTitle = "Direct Flashlight Against Sun"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Photography/parents.jpg",
                    DescriptionTitle = "Parents: Indoor Remote Flashlight"
                }
            );

            return View(media);
        }

        public ActionResult Videography()
        {
            Media media = new Media
            {
                MediaContents = new List<MediaContent>()
            };

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "http://img.youtube.com/vi/QksH65BmjK4/0.jpg",
                    VideoSrc = "https://www.youtube.com/embed/QksH65BmjK4",
                    DescriptionTitle = "Parents: Indoor Remote Flashlight"
                }
            );

            return View(media);
        }

        public ActionResult Angular()
        {
            return View();
        }
    }
}
