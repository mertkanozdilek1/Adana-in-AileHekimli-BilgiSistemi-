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
    public partial class Sonuclar : Form
    {   public string barkodKod;

        SqlConnection conn = new SqlConnection("Data Source= LAPTOP-3KQM3JF1\\SQLEXPRESS; Initial Catalog=Tetkikler; Integrated Security=true");
        public Sonuclar()
        {
            InitializeComponent();
        }

        private void sonuclar_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            try
            {
                DataTable kn = new DataTable();
                SqlDataAdapter adaptor = new SqlDataAdapter("select barkodNo from barkod where tc= '" + textBox1.Text + "'", conn);
                adaptor.Fill(kn);

                string Kod = kn.Rows[0]["barkodNo"].ToString();

                ws_Adana_Lab_Entegre.LiosService servis = new ws_Adana_Lab_Entegre.LiosService();
                ws_Adana_Lab_Entegre.HastaSonucBilgisi[] HastaSonuc = servis.BarkodSonucBilgisi(Kod, "21805034564", "2164");

                DataTable dt = new DataTable();
                dt.Columns.Add("OrnekTipi");
                dt.Columns.Add("Sonuc");
                dt.Columns.Add("SonucAciklama");
                dt.Columns.Add("SonucBirim");
                dt.Columns.Add("SonucDurum");
                dt.Columns.Add("SonucOnayTarihi", typeof(System.DateTime));
                dt.Columns.Add("SonucReferans");
                dt.Columns.Add("SonucYorum");
                dt.Columns.Add("TestAdi");
                dt.Columns.Add("TestGrupAdi");
                dt.Columns.Add("TestID");
                dt.Columns.Add("TestParametreAdi");

                for (int i = 0; i < HastaSonuc[0].TestSonuclari.Length; i++)
                {
                    dt.Rows.Add(HastaSonuc[0].TestSonuclari[i].OrnekTipi, HastaSonuc[0].TestSonuclari[i].Sonuc, HastaSonuc[0].TestSonuclari[i].SonucAciklama, HastaSonuc[0].TestSonuclari[i].SonucBirim, HastaSonuc[0].TestSonuclari[i].SonucDurum, HastaSonuc[0].TestSonuclari[i].SonucOnayTarihi, HastaSonuc[0].TestSonuclari[i].SonucReferans, HastaSonuc[0].TestSonuclari[i].SonucYorum, HastaSonuc[0].TestSonuclari[i].TestAdi, HastaSonuc[0].TestSonuclari[i].TestGrupAdi, HastaSonuc[0].TestSonuclari[i].TestID, HastaSonuc[0].TestSonuclari[i].TestParametreAdi);
                }
                conn.Close();
                gridControl1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Tc hatalı yada bu tc ye ait kullanıcı yok");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.pdf|*.pdf";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                gridControl1.ExportToPdf(saveFileDialog1.FileName);
            }
        }
    }
}
