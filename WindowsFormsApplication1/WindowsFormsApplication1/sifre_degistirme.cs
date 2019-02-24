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
    public partial class sifre_degistirme : Form
    {
        public sifre_degistirme()
        {
            InitializeComponent();
            textBox3.PasswordChar = '*';
        }
        SqlConnection conn = new SqlConnection("Data Source= LAPTOP-3KQM3JF1\\SQLEXPRESS; Initial Catalog=Kullanici-Hasta; Integrated Security=true");
        private void button1_Click(object sender, EventArgs e)
           
        {
            if (Kullanici_giris.kulsifre.ToString() == textBox1.Text.ToString())
            {
                if (textBox2.Text == textBox3.Text)
                {

                    conn.Close();
                    conn.Open();
                    string kmt = "update kullanici_list set KSifre=@ks where KAdi=@ka";
                    SqlCommand komut = new SqlCommand(kmt, conn);
                    komut.Parameters.AddWithValue("@ks", textBox2.Text);
                    komut.Parameters.AddWithValue("@ka", Kullanici_giris.kuladi);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Şifreniz Güncellenmiştir");
                }
                else
                {
                    MessageBox.Show("Şifreler Uyuşmamaktadır");
                }
            }

            else
                MessageBox.Show("Mevcut Şifre yanlıştır");
        }
    }
}
