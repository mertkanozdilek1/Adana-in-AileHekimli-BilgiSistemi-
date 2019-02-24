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
using System.Diagnostics;
namespace WindowsFormsApplication1
{
    public partial class Anaform : Form
    {
       
        public Anaform()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source= LAPTOP-3KQM3JF1\\SQLEXPRESS; Initial Catalog=Kullanici-Hasta; Integrated Security=true");


        public static int secili_hasta;


        static Hasta secili = new Hasta();



        private void Anaform_Load(object sender, EventArgs e)
        {
            secili_hasta = 0;


            listele();

        }

        

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"select * from hasta_kayit  where  TC like  '%" + textBox1.Text + "%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Refresh();
            conn.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//gridviev üzerinden tıklayarak islem yapılacak hastayı secme
        {

           
            comboBox1.Items.Add("ERKEK");
            comboBox1.Items.Add("KADIN");
            int secili_alan = dataGridView1.SelectedCells[0].RowIndex;
             secili.Id =Convert.ToInt32 (dataGridView1.Rows[secili_alan].Cells[0].Value);
            secili.Tc = Convert.ToDouble(dataGridView1.Rows[secili_alan].Cells[1].Value.ToString());
            secili.Ad = dataGridView1.Rows[secili_alan].Cells[2].Value.ToString();
            secili.Soyad = dataGridView1.Rows[secili_alan].Cells[3].Value.ToString();
            secili.DogumTarihi = Convert.ToDateTime(dataGridView1.Rows[secili_alan].Cells[6].Value);
            secili.TelNo = dataGridView1.Rows[secili_alan].Cells[4].Value.ToString();
            secili.TelNo = dataGridView1.Rows[secili_alan].Cells[5].Value.ToString();
            textBox6.Text = secili.Id.ToString();
            textBox2.Text = secili.Tc.ToString();
            textBox3.Text = secili.Ad;
            textBox4.Text = secili.Soyad;
            dateTimePicker1.Value = secili.DogumTarihi;
            textBox5.Text = secili.TelNo;
            comboBox1.Text = secili.Cinsiyet;

        }

        #region Butonlar
        private void simpleButton1_Click(object sender, EventArgs e)//hasta_ekle formuna geçis
        { 
            Hasta_ekle frm = new Hasta_ekle();
            frm.Show();
            this.Hide();
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)//tekik güncelle formuna geçis
        {
            Tekik_güncelle tetkik = new Tekik_güncelle();
            tetkik.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)//hastaya uygulanacak testleri seçme ekranına geçiş
        {
            if (secili_hasta == 1)
            {
                Tetkik_ekle tetkik = new Tetkik_ekle();
                tetkik.Show();

                secili_hasta = 0;
            }
            else
                MessageBox.Show("Lütfen Hasta Seçin");
        }

        private void simpleButton4_Click(object sender, EventArgs e)//sonuç ekranına geçiş
        {
            Sonuclar sonc = new Sonuclar();
            sonc.Show();

        }

        private void simpleButton5_Click(object sender, EventArgs e)//hastanın tüm sonuçlarını görme ekranına geçiş
        {

            Tcilesonuc ts = new Tcilesonuc();
            ts.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)//sil butonuu
        {
            Hasta.HastaSil(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            listele();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            List<Hasta> update = new List<Hasta>
            {
                new Hasta()
            {
                    Id =Convert.ToInt32(textBox6.Text),
                    Tc=Convert.ToDouble(textBox2.Text),
                    Ad=textBox3.Text,
                    Soyad=textBox4.Text,
                   TelNo=textBox5.Text,
                   Cinsiyet=comboBox1.Text,
                   DogumTarihi=dateTimePicker1.Value


            }

            };

            int islem = Hasta.Guncelle(update);
            if (islem > 0)

            {
                MessageBox.Show("Kayıt güncellendi");
                listele();
                Textbox_Temizle(this.groupBox1);
            }
            else
                MessageBox.Show("Bir hata oluştu");


           



        }//güncelle butonu

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                MessageBox.Show("hasta seçildi");
                
            }
            else
                MessageBox.Show("Lütfen hasta tablosu üzerinden hasta seçiniz");

                secili_hasta++;

        }//hasta seç butonu (test yapılacak hastayı seçme)
       
        #endregion

       #region ToolStripMenu
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.bademahbs.com/iletisimm.html");
        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanıcı_bilgileri kb = new kullanıcı_bilgileri();
            kb.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifre_degistirme sd = new sifre_degistirme();
            sd.Show();
        }

        private void sorunVeŞikayetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sorun_sikayet ss = new sorun_sikayet();
            ss.Show();
        }

        private void labDuyurularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            duyuru dy = new duyuru();
            dy.Show();
        }
        #endregion


        #region fonksiyonlar

        private void Textbox_Temizle(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.Controls.Count > 0)
                {
                    Textbox_Temizle(c);
                }
            }
        }
 
       public static Hasta SecilenHastaBilgisi()
            {

            return secili;

                           }

       public void listele()
        {
            dataGridView1.DataSource = Hasta.Hastagetir();
             }
        
        #endregion


    }





}
