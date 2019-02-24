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
    public partial class Hasta_ekle : Form
    {
        public Hasta_ekle()
        {
            InitializeComponent();
        }
        Anaform frm = new Anaform();
        SqlConnection conn = new SqlConnection("Data Source= LAPTOP-3KQM3JF1\\SQLEXPRESS; Initial Catalog=Kullanici-Hasta; Integrated Security=true");

        private void Hasta_ekle_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("ERKEK");
            comboBox1.Items.Add("KADIN");

        }
     

        private void Hasta_ekle_FormClosed(object sender, FormClosedEventArgs e)
        {
           // frm.listele();
            frm.Show();

        }

        private void KAYDET_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.Text != "")
            {
                DataSet ds = new DataSet();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                ds.Clear();
                string sorgu = "insert into hasta_kayit(TC,Ad,Soyad,Tel,Cinsiyet,Dogum_Tarihi) VALUES(@tc,@ad,@soyad,@tel,@cinsiyet,@dt)";
                SqlCommand komut = new SqlCommand(sorgu, conn);
                komut.Parameters.AddWithValue("@tc", textBox1.Text);
                komut.Parameters.AddWithValue("@ad", textBox2.Text);
                komut.Parameters.AddWithValue("@soyad", textBox3.Text);
                komut.Parameters.AddWithValue("@tel", textBox4.Text);
                komut.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
                komut.Parameters.AddWithValue("@dt", dateTimePicker1.Value);

                komut.ExecuteNonQuery();


                MessageBox.Show("KAYIT BASARILI");


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                dateTimePicker1.Refresh();
                textBox4.Clear();

                conn.Close();
            }
            else
            {
                MessageBox.Show("Eksik bilgiler var!");

            }  
        }
    }
}



