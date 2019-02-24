using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail; //Gerekli olan kütüphanemiz bu.
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Sifre_mail : Form
    {
        SqlConnection conn = new SqlConnection("Data Source= LAPTOP-3KQM3JF1\\SQLEXPRESS; Initial Catalog=Kullanici-Hasta; Integrated Security=true");
      
        

public bool Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("ibrahimmertkan@gmail.com");//buraya kendi gmail hesabınız
            //
            ePosta.To.Add(textBox2.Text);//bura şifre unutanın maili textboxdan çekdiniz.
            ;
         
            ePosta.Subject = konu; //butonda veri tabanı çekdikden sonra aldımız değer konu değeri
            //
            ePosta.Body = icerik;  // buda şifremiz
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential("ibrahimmertkan@gmail.com", "11578398406");
//kendi gmail hesabiniz var şifresi
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
 
        }
        
        public Sifre_mail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (conn.State == ConnectionState.Closed) //eğer bağlantı kapalıysa
            {
                conn.Open(); //bağlantıyı aç
            }

             string sql = "SELECT * FROM kullanici_list WHERE KAdi=@KAdi AND email=@email";
             SqlParameter prms1 = new SqlParameter("@KAdi",  textBox1.Text.ToUpper());
             SqlParameter prms2 = new SqlParameter("@email", textBox2.Text);
             SqlCommand cmd = new SqlCommand(sql, conn);
             cmd.Parameters.Add(prms1);
             cmd.Parameters.Add(prms2);
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);
             if (dt.Rows.Count > 0)
            {
                //burada verdiği tc ve mail doğruysa gireceği için şifreyi veritabanından çekip gönder fonksiyonunu kullanarak göndereceğiz

                string sifre = dt.Rows[0]["KSifre"].ToString();
                //veritabanından çekdik            
                MessageBox.Show("Girmiş Oldunuz Bilgiler Uyuşuyor Şifreniz Mail adresinize yollanıyor");
                Gonder("Unutmus Oldugunuz Sifreniz Ektedir", sifre);
                //gönder paremetresi ile içeriğe 2 string değer yolladık biri mesajımız öbürü şifresi
                conn.Close();
            }
            else
            {
                MessageBox.Show("Bilgileriniz Uyuşmadı");
            }
            conn.Close();
        }
        }
    }

