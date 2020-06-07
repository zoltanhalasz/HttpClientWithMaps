using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientDemo.Models
{
    public class LocationModel
    {
        public int distance { get; set; }      
        public string title { get; set; }
        public string location_type { get; set; }
        public int woeid { get; set; }
        public string latt_long { get; set; }
        public double latt { get; set; }
        public double _long { get; set; }
    }
}


