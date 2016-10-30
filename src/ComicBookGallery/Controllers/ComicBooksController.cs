using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Something.</p>",
                Artists = new Artist[] {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" }
                }
            };
            return View(comicBook);
        }
    }
}