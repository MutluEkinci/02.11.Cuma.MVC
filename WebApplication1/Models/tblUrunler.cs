using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class tblUrunler
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int KategoriID { get; set; }
        public decimal Fiyat { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }

    }
}