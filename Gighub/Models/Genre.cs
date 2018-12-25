﻿using System.Collections.Generic;

namespace Gighub.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        public IList<Gig> Gigs { get; set; }

    }
}