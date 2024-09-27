using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _323_matvelickov_rando
{
    class Trackpoint 
    {
        public double _latitude;
        public double _longitude;
        public double _elevation;

        public Trackpoint(double latitude, double longitude, double elevation)
        {
            _latitude = latitude;
            _longitude = longitude;
            _elevation = elevation;
        }

    }
}
