using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Araba
    {
        public int ArabaID { get; set; }
        public string Plaka { get; set; }
        public int MarkaID { get; set; }
        public int RenkID { get; set; }
        public decimal Fiyat { get; set; }
    }
}