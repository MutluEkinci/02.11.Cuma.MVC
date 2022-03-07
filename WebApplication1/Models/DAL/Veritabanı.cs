using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models.DAL;
namespace WebApplication1.Models.DAL
{
    public class Veritabanı
    {
        string connstr = @"Data Source=DESKTOP-TUMHS1A\MS_SQL_2019;initial catalog=Calısma;integrated security=true";
        public void Baglantı(string UrunAdi, int KategoriID, decimal Fiyat, string Resim, string Aciklama)
        {
            
            SqlConnection conn = new SqlConnection(connstr);

            conn.Open();

            string strSQL = "insert into tbl_Urunler values(@UrunAdi,@KategoriID,@Fiyat,@Resim,@Aciklama)";

            SqlCommand cmd = new SqlCommand(strSQL, conn);

            
            cmd.Parameters.AddWithValue("@UrunAdi",UrunAdi);
            cmd.Parameters.AddWithValue("@KategoriID",KategoriID);
            cmd.Parameters.AddWithValue("@Fiyat", Fiyat);
            cmd.Parameters.AddWithValue("@Resim",Resim);
            cmd.Parameters.AddWithValue("@Aciklama",Aciklama);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<tblUrunler> TumUrunler()
        {
            List<tblUrunler> urunler = new List<tblUrunler>();
            SqlConnection conn = new SqlConnection(connstr);

            conn.Open();

            SqlCommand cmd = new SqlCommand("select*from tbl_Urunler", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tblUrunler u = new tblUrunler 
                { 
                    UrunID = Convert.ToInt32(dr[0]), 
                    UrunAdi = dr[1].ToString(), 
                    KategoriID = Convert.ToInt32(dr[2]), 
                    Fiyat = Convert.ToDecimal(dr[3]), 
                    Resim = dr[4].ToString(), 
                    Aciklama = dr[5].ToString() 
                };
                urunler.Add(u);
            }
            conn.Close();
            return urunler;
        }
        public void Delete(int UrunID)
        {
            SqlConnection conn = new SqlConnection(connstr);

            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from tbl_Urunler urunID=@urunID");

            cmd.Parameters.AddWithValue("@urunID", UrunID);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        
    }
}