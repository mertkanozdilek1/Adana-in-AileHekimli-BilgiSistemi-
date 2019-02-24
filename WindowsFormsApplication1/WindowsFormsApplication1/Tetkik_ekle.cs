using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Tetkik_ekle : Form
    {
        SqlConnection conn = new SqlConnection("Data Source= LAPTOP-3KQM3JF1\\SQLEXPRESS; Initial Catalog=Tetkikler; Integrated Security=true");
        
        
        public Tetkik_ekle()
        {
            InitializeComponent();
        }
      

       /* public string tc;
        public string ad;
        public string soyad;
        public string cinsiyet;
        public DateTime dogumTarih;*/
        public int  secilibuton;
Hasta hasta = Anaform.SecilenHastaBilgisi();

        private void Tetkik_ekle_Load(object sender, EventArgs e)
        {

            
        
         
            
            textBox2.Text = hasta.Tc.ToString();
            textBox2.ReadOnly = true;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * from TETKIKLER";
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                listBox1.Items.Add(rd["TetkikAdi"].ToString());

            }
            conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//listbox1 den arama yapmak
        {
            listBox1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * from TETKIKLER where TetkikAdi like '%" + textBox1.Text + "%'";
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                listBox1.Items.Add(rd["TetkikAdi"].ToString());

            }
            conn.Close();

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.GetSelected(i) == true)
                {
                    if (!listBox2.Items.Contains(listBox1.Items[i]))
                    {

                        listBox2.Items.Add(listBox1.Items[i]);

                    }
                    else
                        MessageBox.Show("BU TETKİK EKLENDİ!");

                }
            }



        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
        public string tetkikKoduVer(string TetkikAd)//tetkiğin adıile referans kodu alma fonksiyonu
        {

            conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"select ReferansNo from TETKIKLER where TetkikAdi='" + TetkikAd + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string Kod = dt.Rows[0]["ReferansNo"].ToString();
            return Kod;
        

        }

        private void simpleButton5_Click(object sender, EventArgs e)//GÖNDER BUTONU
        {
            ws_Adana_Lab_Entegre.LiosService servis = new ws_Adana_Lab_Entegre.LiosService();
            int[] tetkik = new int[listBox2.Items.Count];
            DataTable dt = new DataTable();

            for (int i = 0; i < listBox2.Items.Count; i++)
            {

                string tetkikAdi = listBox2.Items[i].ToString();
                tetkik[i] = Convert.ToInt32(tetkikKoduVer(tetkikAdi));

            }

            if (secilibuton == 1)//ilk gönderme  barkodu veritabanına kaydetme tc ile ve barkod ile tetkikleri kaydetme 
            {
       
                ws_Adana_Lab_Entegre.TestEkleSonuc[] sonucbarkod = servis.TestEkle("21805034564", "2164", "", hasta.Tc.ToString(), hasta.Ad, hasta.Soyad, hasta.Cinsiyet, hasta.DogumTarihi, "Z00.0","", "", "", "", "", "", "", "", tetkik);
                if (sonucbarkod[0].Sonuc == "Başarılı")
                {
                    conn.Close();
                    conn.Open();
                    SqlCommand komut = new SqlCommand("insert into Barkod_tc(barkodNo,tc) VALUES('" + sonucbarkod[0].Barkod + "','" + hasta.Tc + "')", conn);
                    komut.ExecuteNonQuery();
                    conn.Close();

                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        conn.Open();
                        SqlCommand kmt = new SqlCommand("insert into Barkod_tetkik(barkodNo,TekikAdi) VALUES('" + sonucbarkod[0].Barkod + "','" + listBox2.Items[i].ToString() + "')", conn);
                        kmt.ExecuteNonQuery();


                    }

                }
            }


            else if (secilibuton == 2)//gönderilen tetkik yenileme ve barkod ile tetkikleri silip kaydeme
            {

                
             
                string silmeSorgusu2 = "DELETE from Barkod_tetkik   where barkodNo=@barkodNo2";
                SqlCommand silKomutu2 = new SqlCommand(silmeSorgusu2, conn);
                silKomutu2.Parameters.AddWithValue("@barkodNo2", comboBox1.Text);
                silKomutu2.ExecuteNonQuery();
                string msj = servis.TestGuncelle(comboBox1.Text, "21805034564", "2164", tetkik);
              
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                  
                    SqlCommand kmt = new SqlCommand("insert into Barkod_tetkik(barkodNo,TetkikAdi) VALUES('" + comboBox1.Text + "','" + listBox2.Items[i].ToString() + "')", conn);
                    kmt.ExecuteNonQuery();

                   
                }
                MessageBox.Show(msj);
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)//tetkik güncelle butonu
        {
           

            secilibuton = 2;
          
            groupBox2.Text = "Güncellenecek Barkodu Seçin";
            groupBox2.Visible = true;
            groupBox1.Visible = true;
            simpleButton4.Visible = false;
            


        }

        private void simpleButton2_Click(object sender, EventArgs e)//tetkik iptal etme butonu
        {
            
            
            simpleButton4.Visible = true;
            groupBox2.Text = "İptal Edilecek Barkodu Seçin";
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void simpleButton3_Click(object sender, EventArgs e)//Tetkik seç butuonu
        {
           
            secilibuton= 1;
    
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void simpleButton4_Click(object sender, EventArgs e)//barkod sil butonu seçilen barkodu silme
        {
            conn.Close();
            conn.Open();
            ws_Adana_Lab_Entegre.LiosService servis = new ws_Adana_Lab_Entegre.LiosService();

            string a = servis.BarkodSil("21805034564", "2164", comboBox1.Text);
            MessageBox.Show(a);
          
                string silmeSorgusu = "DELETE from Barkod_tc   where barkodNo=@barkodNo";
             
                SqlCommand silKomutu = new SqlCommand(silmeSorgusu, conn);
                silKomutu.Parameters.AddWithValue("@barkodNo",comboBox1.Text);
                silKomutu.ExecuteNonQuery();
            
                string silmeSorgusu2 = "DELETE from Barkod_tetkik   where barkodNo=@barkodNo2";
                SqlCommand silKomutu2 = new SqlCommand(silmeSorgusu2, conn);
                silKomutu2.Parameters.AddWithValue("@barkodNo2", comboBox1.Text);
                silKomutu2.ExecuteNonQuery();

                conn.Close();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
            comboBox1.Items.Clear();
            conn.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT barkodNo FROM Barkod_tc where tc='" + textBox2.Text + "'";
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["barkodNo"]);
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//Comboboxtan Güncellenecek veya silinecek tetkikleri secmek
        {
            if (secilibuton == 2)
            {
                listBox2.Items.Clear();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * from Barkod_tetkik where barkodNo like '%" + comboBox1.Text + "%'";
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    listBox2.Items.Add(rd["TetkikAdi"].ToString());

                }
                conn.Close();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



       


    }
}
