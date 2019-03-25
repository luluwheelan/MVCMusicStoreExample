using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Genre
    {
        public virtual int GenreId { get; set; }
        [DisplayName("Genre Name")]
        public virtual String Name { get; set; }
        public virtual String Description { get; set; }
        [JsonIgnoreAttribute]
        public virtual List<Album> Albums { get; set; }
    }
}