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
        public ActionResult Detail(int? id)
        {
            if (id==null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRespository.GetComicBook(id.Value);

            return View(comicBook);
        }
    }
}