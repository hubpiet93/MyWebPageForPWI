using MyWebPageForPWI.DAL;
using MyWebPageForPWI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebPageForPWI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public PhotosContext db = new PhotosContext();
        public ActionResult Index()
        {
            //db.Zdjecia.Add(new Zdjecie(){Tytul="asd",Opis="asdsda"});
            //db.SaveChanges();
            return View();
        }
    }
}