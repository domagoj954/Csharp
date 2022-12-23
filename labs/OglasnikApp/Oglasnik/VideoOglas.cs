﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oglasnik {
    class VideoOglas : Oglas {
        public VideoOglas(string naslov, string tekst, string link) : base(naslov, tekst) {
            Link = link;
        }
        public override string ToString() {
            return base.ToString() + " " + Link;
        }
        public string Link { get; set; }
    }
}
