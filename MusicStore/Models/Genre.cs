using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Genre
    {
        public virtual int GenreId { get; set; }
        public virtual String Name { get; set; }
        public virtual String Description { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}