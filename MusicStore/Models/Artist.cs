﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Artist
    {
        public virtual int ArtistId { get; set; }
        [DisplayName("Artist Name")]
        public virtual String Name { get; set; }

    }
}