using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDT5.Helper;
using TMDT5.Models;

namespace TMDT5.Controllers
{
    public class SitemapController : Controller
    {
        // GET: Sitemap
        public ActionResult Index()
        {
            var sitemapItems = new List<SitemapItem> 
            {
            new SitemapItem(Url.Action("index", "home"), changeFrequency: SitemapChangeFrequency.Always, priority: 1.0),
            new SitemapItem(Url.Action("about", "home"), lastModified: DateTime.Now),
            new SitemapItem(PathUtils.CombinePaths(Request.Url.GetLeftPart(UriPartial.Authority),"/home/list"))
            };
            return new SitemapResult(sitemapItems);
        }
    }
}