using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1_SearchAlgorithms
{
    public class Route
    {
        public string City { get; set; }
        public decimal Distance { get; set; }

        public Route(string city, decimal distance)
        {
            this.City = city;
            this.Distance = distance;
        }
    }
}