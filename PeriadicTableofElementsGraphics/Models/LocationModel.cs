﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriadicTableofElementsGraphics.Models
{
    class LocationModel
    {
        public double X { get; set; }
        public double Y { get; set; }

        public LocationModel(double x, double y) {
            this.X = x;
            this.Y = y;
        }
    }
}
