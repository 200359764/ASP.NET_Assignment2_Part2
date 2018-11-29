using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using High_M_Music_Records.Models;

namespace SeunghwanKim_ASP.NET_Assignment2_Part1.Models
{
    public class EFArtistsAlbums : IArtistsAlbumsMock
    {

        private High_MMusicRecordsModel db = new High_MMusicRecordsModel();

        public IQueryable<artistsAlbums> ArtistsAlbums { get { return db.ArtistsAlbums; } }

        public void Delete(artistsAlbums artistsAlbum)
        {
            db.ArtistsAlbums.Remove(artistsAlbum);
            db.SaveChanges();
        }

        public artistsAlbums Save(artistsAlbums artistsAlbum)
        {
            if (artistsAlbum.Artist_name == null)
            {
                db.ArtistsAlbums.Add(artistsAlbum);
            }
            else
            {
                db.Entry(artistsAlbum).State = System.Data.Entity.EntityState.Modified;
            }

            db.SaveChanges();
            return artistsAlbum;
        }
    }
}