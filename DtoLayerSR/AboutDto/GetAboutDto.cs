﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayerSR.AboutDto
{
    public class GetAboutDto
    {
        public int AboutID { get; set; }

        public string AboutName { get; set; }

        public string AboutDescription { get; set; }

        public string AboutImageUrl { get; set; }
    }
}