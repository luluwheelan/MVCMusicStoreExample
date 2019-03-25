using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MusicStore.App_Start;
using MusicStore.Models;

namespace MusicStore.Controllers.API
{
    public class AlbumsController : ApiController
    {
        private IAlbumBL bl;

        public AlbumsController(IAlbumBL bl)
        {
            this.bl = bl;
        }

        // GET: api/Albums
        public IQueryable<Album> GetAlbums()
        {
            return bl.GetAlbums();
        }

        // GET: api/Albums/5
        [ResponseType(typeof(Album))]
        public IHttpActionResult GetAlbum(int id)
        {
            Album album = bl.GetAlbum(id);
            if (album == null)
            {
                return NotFound();
            }

            return Ok(album);
        }

        // PUT: api/Albums/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAlbum(int id, Album album)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != album.AlbumId)
            {
                return BadRequest();
            }

            

            try
            {
                bl.UpdateAlbum(id, album);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlbumExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Albums
        [ResponseType(typeof(Album))]
        public IHttpActionResult PostAlbum(Album album)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bl.CreateAlbum(album);

            return CreatedAtRoute("DefaultApi", new { id = album.AlbumId }, album);
        }

        // DELETE: api/Albums/5
        [ResponseType(typeof(Album))]
        [BasicAuthentication]
        public IHttpActionResult DeleteAlbum(int id)
        {
            Album album = bl.GetAlbum(id); ;
            if (album == null)
            {
                return NotFound();
            }

            bl.DeleteAlbum(album);

            return Ok(album);
        }

        private bool AlbumExists(int id)
        {
            return bl.GetAlbum(id) != null;
        }
    }
}