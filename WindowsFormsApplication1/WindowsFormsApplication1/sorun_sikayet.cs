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
    public partial class sorun_sikayet : Form
    {
        public sorun_sikayet()
        {
            InitializeComponent();
        }

        bool dosya = false;
        string dosyaadresi;
        public bool Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress(kullanıcı_bilgileri.e_mail);//buraya kendi gmail hesabınız
            //
            ePosta.To.Add("ibrahimmertkan@gmail.com");//bura şifre unutanın maili textboxdan çekdiniz.
            

            ePosta.Subject = konu; //butonda veri tabanı çekdikden sonra aldımız değer konu değeri
            //
            ePosta.Body = icerik;  // buda şifremiz
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential(kullanıcı_bilgileri.e_mail, "parolam");
            //kendi gmail hesabiniz var şifresi
            smtp.Port = 587 ;
            smtp.Host = "smtp.live.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
                MessageBox.Show("Şikayetiniz alınmıştır en yakın sürede size dönüş yapılacaktır");
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string konu = textBox1.Text;
            string icerik = richTextBox1.Text;

            Gonder(konu, icerik);
            textBox1.Clear();
            richTextBox1.Clear();
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                textBox1.Font = fontDialog1.Font;


            }
        }

        private void seçilenFontToolStripMenuItem_Click(object sender, EventArgs e)
        {if(fontDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
        {
            richTextBox1.SelectionFont = fontDialog1.Font;
          
        }
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void seçilenRenkToolStripMenuItem_Click(object sender, EventArgs e)
        {  if(colorDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
        {
            richTextBox1.SelectionColor = colorDialog1.Color;
            
        }

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.rtf|*.rtf"; ;
            if(openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
                dosya = true;
                dosyaadresi = openFileDialog1.FileName;

            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dosya==true)
            {
                richTextBox1.SaveFile(dosyaadresi);

            }
            else
            {
                saveFileDialog1.Filter = "*.rtf|*.rtf";
                if(saveFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                       dosyaadresi=saveFileDialog1.FileName;
                       dosya = true;
                }

            }
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.rtf|*.rtf";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                dosyaadresi = saveFileDialog1.FileName;
                dosya = true;
            }

        }
    }
}
