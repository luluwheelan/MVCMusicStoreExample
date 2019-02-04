using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class MusicStoreContextInitializer : DropCreateDatabaseAlways<MusicStoreContext>
    {

        protected override void Seed(MusicStoreContext context)
        {
            Genre metal = new Genre { Name = "Metal" };
            context.Artists.Add(new Artist { Name = "System of a Down" });
            context.Genres.Add(metal);
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Scars on Broadway" },
                Genre = metal,
                Price = 9.99m,
                Title = "Dictator",
                AlbumArtUrl = "https://i.imgur.com/D5zbJZQ.png"
            });

            base.Seed(context);
        }

    }
}