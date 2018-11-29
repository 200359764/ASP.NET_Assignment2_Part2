using High_M_Music_Records.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeunghwanKim_ASP.NET_Assignment2_Part1.Models
{
    public interface IArtistsAlbumsMock
    {
        IQueryable<artistsAlbums> ArtistsAlbums { get; }
        artistsAlbums Save(artistsAlbums artistsAlbum);
        void Delete(artistsAlbums artistsAlbum);
    }
}
