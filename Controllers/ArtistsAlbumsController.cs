using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using High_M_Music_Records.Models;
using SeunghwanKim_ASP.NET_Assignment2_Part1.Models;

namespace High_M_Music_Records.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ArtistsAlbumsController : Controller
    {
        //private High_MMusicRecordsModel db = new High_MMusicRecordsModel();

        private IArtistsAlbumsMock db;

        public ArtistsAlbumsController()
        {
            this.db = new EFArtistsAlbums();
        }

        public ArtistsAlbumsController(IArtistsAlbumsMock mock)
        {
            this.db = mock;
        }

        // GET: ArtistsAlbums
        public ActionResult Index()
        {
            var artistAlbums = db.ArtistsAlbums.Include(a => a.Artist_name);
            //return View(db.ArtistsAlbums.ToList());
            return View("Index", artistsAlbums.ToList());
        }

        //// GET: ArtistsAlbums/Details/5
        //    [AllowAnonymous]
        //public ActionResult Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ArtistsAlbum artistsAlbum = db.ArtistsAlbums.Find(id);
        //    if (artistsAlbum == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(artistsAlbum);
        //}

        //// GET: ArtistsAlbums/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ArtistsAlbums/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Title,Genre,Name_of_Song,Artist_name,Year_of_Release")] ArtistsAlbum artistsAlbum)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.ArtistsAlbums.Add(artistsAlbum);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(artistsAlbum);
        //}

        //// GET: ArtistsAlbums/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ArtistsAlbum artistsAlbum = db.ArtistsAlbums.Find(id);
        //    if (artistsAlbum == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(artistsAlbum);
        //}

        //// POST: ArtistsAlbums/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Title,Genre,Name_of_Song,Artist_name,Year_of_Release")] ArtistsAlbum artistsAlbum)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(artistsAlbum).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(artistsAlbum);
        //}

        //// GET: ArtistsAlbums/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ArtistsAlbum artistsAlbum = db.ArtistsAlbums.Find(id);
        //    if (artistsAlbum == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(artistsAlbum);
        //}

        //// POST: ArtistsAlbums/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    ArtistsAlbum artistsAlbum = db.ArtistsAlbums.Find(id);
        //    db.ArtistsAlbums.Remove(artistsAlbum);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
