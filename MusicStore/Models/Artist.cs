using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Artist
    {
        public virtual int ArtistId { get; set; }
        public virtual String Name { get; set; }

    }
}