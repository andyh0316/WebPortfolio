using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPortfolio.Models
{
    public class Media
    {
        public List<MediaContent> MediaContents { get; set; }
    }

    public class MediaContent
    {
        public string ImageSrc { get; set; }
        public string VideoSrc { get; set; }
        public string DescriptionTitle { get; set; }
        public string DescriptionClass { get; set; }
        public string Description { get; set; }
    }
}
