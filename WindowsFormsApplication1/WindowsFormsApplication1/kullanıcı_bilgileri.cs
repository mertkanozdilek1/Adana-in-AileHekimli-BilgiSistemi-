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
    public partial class kullanıcı_bilgileri : Form
    {
        public kullanıcı_bilgileri()
        {
            InitializeComponent();
        }
        public static string e_mail;
        SqlConnection conn = new SqlConnection("Data Source= LAPTOP-3KQM3JF1\\SQLEXPRESS; Initial Catalog=Kullanici-Hasta; Integrated Security=true");
        
        private void kullanıcı_bilgileri_Load(object sender, EventArgs e)
        {
            textBox1.Text = Kullanici_giris.kuladi.ToUpper();
            textBox2.Text=Kullanici_giris.kulsifre;
            textBox2.ReadOnly = true;
            string sql = "SELECT email FROM kullanici_list WHERE KAdi=@KAdi";
               SqlParameter prms1 = new SqlParameter("@KAdi",  textBox1.Text);
               SqlCommand cmd = new SqlCommand(sql, conn);
               cmd.Parameters.Add(prms1);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
             da.Fill(dt);
             if (dt.Rows.Count > 0)
             {
                 //burada verdiği tc ve mail doğruysa gireceği için şifreyi veritabanından çekip gönder fonksiyonunu kullanarak göndereceğiz

          e_mail = dt.Rows[0]["email"].ToString();
                 textBox3.Text = e_mail;
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conn.Close();
            conn.Open();
            string kmt = "update kullanici_list set KAdi=@ka,email=@email";
            SqlCommand komut = new SqlCommand(kmt, conn);
            komut.Parameters.AddWithValue("@ka", textBox1.Text);
            komut.Parameters.AddWithValue("@email", textBox3.Text);
  
           int a= komut.ExecuteNonQuery();
            if (a > 0)
                MessageBox.Show("Güncellenmiştir");
            else
                MessageBox.Show("Hata Vardır");
        }
    }
}
