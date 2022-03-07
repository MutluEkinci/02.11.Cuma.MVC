using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ArabaVM
    {
        public Araba araba { get; set; }
        public List<Marka> markalar { get; set; }
        public List<Renk> renkler { get; set; }
    }
}