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
            //Date Time practice stuff
            if (DateTime.Today.DayOfWeek==DayOfWeek.Monday)
            {
                //Redirect is a method of Action Result Class
                return  Redirect("/");
            }
            //Content is a method of Action Result Class
            return Content("Hello, From the Comic Books Controller!");
        }
    }
}