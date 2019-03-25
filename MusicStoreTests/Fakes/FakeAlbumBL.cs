using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreTests.Fakes
{
    class FakeAlbumBL : IAlbumBL
    {
        public void CreateAlbum(Album a)
        {
            return;
        }

        public void DeleteAlbum(Album a)
        {
            return;
        }

        private List<Album> createAlbums()
        {
            Genre metal = new Genre { Name = "Metal" };
            List<Album> albums = new List<Album>() {
            new Album
            {
                AlbumId=1,
                Artist = new Artist { Name = "album artist 2" },
                Genre = metal,
                Price = 19.99m,
                Title = "album 1",
                AlbumArtUrl = "https://i.imgur.com/D5zbJZQ.png"
            },
            new Album
            {
                AlbumId=2,
                Artist = new Artist { Name = "album artist 2" },
                Genre = metal,
                Price = 19.99m,
                Title = "album 2",
                AlbumArtUrl = "https://i.imgur.com/D5zbJZQ.png"
            },
            new Album
            {
                AlbumId=3,
                Artist = new Artist { Name = "album artist 2" },
                Genre = metal,
                Price = 19.99m,
                Title = "album 3",
                AlbumArtUrl = "https://i.imgur.com/D5zbJZQ.png"
            }};
            return albums;
        }

        public Album GetAlbum(int id)
        {
            List<Album> albums = createAlbums();
            Album toReturn = albums.First(x => x.AlbumId == id);
            return toReturn;
        }

        public IQueryable<Album> GetAlbums()
        {
            return createAlbums().AsQueryable();
        }
        public bool UpdateRan = false;
        public int id;
        public Album a;
        public void UpdateAlbum(int id, Album a)
        {
            UpdateRan = true;
            this.id = id;
            this.a = a;
            return;
        }
    }
}
