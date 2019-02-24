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
    public partial class Kullanici_giris : Form
    {
        SqlConnection conn = new SqlConnection("Data Source= LAPTOP-3KQM3JF1\\SQLEXPRESS; Initial Catalog=Kullanici-Hasta; Integrated Security=true");
        public static string kuladi;
        public static string kulsifre;
        public Kullanici_giris()
        {
            InitializeComponent();
            textkullanicisifre.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textkullaniciadi.Text) ||
                            String.IsNullOrWhiteSpace(textkullanicisifre.Text))
            {
                MessageBox.Show("Giriş Başarısız! Eksiksiz Giriniz!", "..:: HATA ::..",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

                conn.Open(); // Bağlantıyı aç.
                // Sorgumuz. 
                string sql = "SELECT * FROM kullanici_list WHERE KAdi=@KAdi AND KSifre=@KSifre";
                SqlParameter prms1 = new SqlParameter("@KAdi", textkullaniciadi.Text.ToUpper());
                SqlParameter prms2 = new SqlParameter("@KSifre", textkullanicisifre.Text);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(prms1);
                cmd.Parameters.Add(prms2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Hoşgeldin " + textkullaniciadi.Text.ToUpper());

                    Anaform af = new Anaform();
                    af.Show();
                    kuladi = textkullaniciadi.Text;
                    kulsifre = textkullanicisifre.Text;
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Veritabanında böyle bir kullanıcı bulunamadı");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textkullaniciadi.Clear();
            textkullanicisifre.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// sfre mail ekranı
        {
            Sifre_mail sf = new Sifre_mail();
            sf.Show();
        }
    }
}
