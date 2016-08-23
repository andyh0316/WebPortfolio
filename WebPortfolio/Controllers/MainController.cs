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

        public void DownloadResumePdf()
        {
            Response.ContentType = "application/octet-stream";
            Response.AppendHeader("Content-Disposition", "attachment; filename=resume.pdf");
            Response.TransmitFile(Server.MapPath("/Content/Resume/resume.pdf"));
            Response.End();
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
                    ImageSrc = "/Content/Redesign/Cobro1.png",
                    DescriptionTitle = "Cobro Compass Landing Page",
                    DescriptionClass = "green",
                    Description = "The landing page for the Cobro Compass application. "
                }    
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/Cobro2.png",
                    DescriptionTitle = "Cobo Compass Students Page",
                    DescriptionClass = "green",
                    Description = "The Students one page application has many features that are hidden at first. You can use the search box to quickly search students by their ID or names." +
                    "You can also use the Advanced search box for more filters such as Current Grade Level. You could use the checkboxes on the left to select students to perform " +
                    "bulk updates. And although paginations are server side, the entire page never refreshes and will remember what you've selected on the previous paginations. " +
                    "Lastly, you can click on a student row to view student details without leaving the page. All this is made easy by angularJS."

                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/Cobro3.png",
                    DescriptionTitle = "Login Box",
                    DescriptionClass = "green",
                    Description = "The login box is something users see first everyday when using the application. It should be simple and big " +
                    "so that it is easier for users to type in their crendentials. Icons are used to subsitutes the labels for fields because it should " +
                    "be intuitive enough for users to figure which field is what. "
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/PatientAccountLedger.png",
                    DescriptionTitle = "SupraMed Patient Page",
                    DescriptionClass = "green",
                    Description = "The patient page prioritize information by different font-sizes, font-weight, colors and positions. For pages like these where users use everyday, " +
                    "we don't want to make everything look flat because we want the users to be able to find information very quickly based. By giving them different attributes, the users " +
                    "will slowly adapt to them and remember where to look for the information they need"
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "/Content/Redesign/Photo.png",
                    DescriptionTitle = "SupraMed Photo Management",
                    DescriptionClass = "green",
                    Description = "The photo management feature loads the thumbnails into the container first. Then in the background, it will start to load the actual images in order. If " +
                    "the user clicks on an image that has not been loaded yet it will priorize that image for loading. This is because we want the user to be able to open images as fast as possible."
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
                    ImageSrc = "/Content/Photography/IMG_4003.jpg",
                    DescriptionTitle = "Ceiling Flashlight"
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
            string optionParams = "?enablejsapi=1&rel=0";
            Media media = new Media
            {
                MediaContents = new List<MediaContent>()
            };

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "http://img.youtube.com/vi/nJf0DIEUAdU/0.jpg",
                    VideoSrc = "https://www.youtube.com/embed/nJf0DIEUAdU" + optionParams,
                    DescriptionTitle = "Trailer",
                    Description = "A sample trailer of a movie I made for student organization in college for members. " +
                    "Won top 3 student videos for Chinese CCTV awards ceremony at USC."
                }
            );

            media.MediaContents.Add(
                new MediaContent
                {
                    ImageSrc = "http://img.youtube.com/vi/N1sHoejKG8A/0.jpg",
                    VideoSrc = "https://www.youtube.com/embed/N1sHoejKG8A" + optionParams,
                    DescriptionTitle = "Commmercial",
                    Description = "A commercial video made for NextHomeTech, a start up mobile controlled lightbulb company."
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
