using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using High_M_Music_Records;
using High_M_Music_Records.Models;

namespace High_M_Music_Records.Controllers
{
    public class RecordsController : Controller
    {
        private High_MMusicRecordsModel db = new High_MMusicRecordsModel();

        // GET: Records
        public ActionResult Index()
        {
            var genre = db.Table_1.ToList();
            return View(genre);
        }

        public ActionResult Artist(String ArtistName)
        {
            ViewBag.ArtistName = ArtistName;
            return View();
        }
    }
}