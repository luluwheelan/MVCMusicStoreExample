using System.Linq;

namespace MusicStore.Models
{
    public interface IAlbumBL
    {
        void CreateAlbum(Album a);
        void DeleteAlbum(Album a);
        Album GetAlbum(int id);
        IQueryable<Album> GetAlbums();
        void UpdateAlbum(int id, Album a);
    }
}