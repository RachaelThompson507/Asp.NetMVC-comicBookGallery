using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        private ComicBookRepository _comicBookRespository = null;

        public ComicBooksController()
        {
            _comicBookRespository = new ComicBookRepository();
        }
        //Action result is the base class for most actions in a Controller base class
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Dan Slott", Role="Script"},
                    new Artist() {Name = "Humberto Ramos", Role="Pencils"},
                    new Artist() {Name = "Victor Olazaba", Role="Inks"},
                    new Artist() {Name = "Edgar Delgado", Role="Colors"},
                    new Artist() {Name = "Chris Eliopoulos", Role="Letters"},
                }
        };
            return View(comicBook);
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