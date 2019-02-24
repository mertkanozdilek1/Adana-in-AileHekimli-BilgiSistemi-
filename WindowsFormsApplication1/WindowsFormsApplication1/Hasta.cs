using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   public  class Hasta
    {
        public int Id { get; set; }
        public double Tc { get; internal set; }
        public string Ad { get; internal set; }
        public string Soyad { get; internal set; }
        public DateTime DogumTarihi { get; internal set; }
        public string TelNo { get; internal set; }
        public string Cinsiyet { get; internal set; }

        static SqlConnection conn = new SqlConnection("Data Source= LAPTOP-3KQM3JF1\\SQLEXPRESS; Initial Catalog=Kullanici-Hasta; Integrated Security=true");

        public static DataTable Hastagetir()
        {


            DataTable HASTA = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            HASTA.Clear();
            conn.Close();
            conn.Open();
            adp = new SqlDataAdapter("select *from hasta_kayit", conn);//veritabanı kayitları çekildi
            adp.Fill(HASTA);



            conn.Close();
            return HASTA;

        }

        public static void HastaSil(string s)
        {


            try
            {
                conn.Open();
                SqlCommand komut = new SqlCommand("DELETE  hasta_kayit where hasta_id='" + s + "'", conn);

               komut.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("KAYİT SİLİNDİ");
            }
            catch {
                MessageBox.Show("İslem Gerçekleştirilemedi");

                conn.Close(); }

           
        }

        public static int Guncelle(List<Hasta> liste)
        {
            conn.Open();
            Hasta hasta1 = new Hasta();

            foreach (var hasta2 in liste)
            {
                hasta1.Id = hasta2.Id;
                hasta1.Tc = hasta2.Tc;
                hasta1.Ad = hasta2.Ad;
                hasta1.Soyad = hasta2.Soyad;
                hasta1.TelNo = hasta2.TelNo;
                hasta1.Cinsiyet = hasta2.Cinsiyet;
                hasta1.DogumTarihi = hasta2.DogumTarihi;
            }

            string kmt = "update hasta_kayit set TC=@tc,Ad=@ad,Soyad=@soyad,Dogum_Tarihi=@dt,Tel=@tel,Cinsiyet=@cinsiyet where hasta_id=@id";
            SqlCommand komut = new SqlCommand(kmt, conn);
            komut.Parameters.AddWithValue("@id", hasta1.Id);
            komut.Parameters.AddWithValue("@tc", hasta1.Tc);
            komut.Parameters.AddWithValue("@ad", hasta1.Ad);
            komut.Parameters.AddWithValue("@soyad", hasta1.Soyad);
            komut.Parameters.AddWithValue("@tel", hasta1.TelNo);
            komut.Parameters.AddWithValue("@cinsiyet", hasta1.Cinsiyet);
            komut.Parameters.AddWithValue("@dt", hasta1.DogumTarihi);
            int islem = komut.ExecuteNonQuery();
            return islem;

        }
    }

}
