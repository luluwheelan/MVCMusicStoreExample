using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class AlbumBL : IAlbumBL
    {
        private MusicStoreContext db = new MusicStoreContext();

        public IQueryable<Album> GetAlbums()
        {
            return db.Albums;
        }

        public Album GetAlbum(int id)
        {
            return db.Albums.Find(id);
        }

        public void UpdateAlbum(int id, Album a)
        {
            db.Entry(a).State = EntityState.Modified;
            db.SaveChanges();            
        }
        public void CreateAlbum(Album a)
        {
            db.Albums.Add(a);
            db.SaveChanges();
        }
        public void DeleteAlbum(Album a)
        {
            db.Albums.Remove(a);
            db.SaveChanges();
        }
    }
}