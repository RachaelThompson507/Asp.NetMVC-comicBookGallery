using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller 
    {
        //Action result is the base class for most actions in a Controller base class
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };
            return View();
            /*
            Date Time practice stuff
            if (DateTime.Today.DayOfWeek==DayOfWeek.Monday)
            {
                Redirect is a method of Action Result Class
                return  Redirect("/");
            }
            Content is a method of Action Result Class
            return Content("Hello, From the Comic Books Controller!");
            */
        }
    }
}