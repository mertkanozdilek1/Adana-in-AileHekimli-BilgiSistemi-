using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace WindowsFormsApplication1
{
    public partial class tc_ile_sonuc : Form
    {
        public tc_ile_sonuc()
        {
            InitializeComponent();
        }

        private void tc_ile_sonuc_Load(object sender, EventArgs e)
        {
            
            ws_Adana_Lab_Entegre.EntegreLBYSLabService servis = new ws_Adana_Lab_Entegre.EntegreLBYSLabService();

            ws_Adana_Lab_Entegre.HastaSonucToplu[] hs= servis.TCSonucBilgisi("21805034564", "2164", "11584398278");
        
           
          
            DataTable dt=new DataTable();
             dt.Columns.Add("Aciklama");
            dt.Columns.Add("AdiSoyadi");
            dt.Columns.Add("AileHekimiAdi");
            dt.Columns.Add("BabaAdi");
            dt.Columns.Add("Barkod");
            dt.Columns.Add("BirimAdi");
            dt.Columns.Add("DogumTarihi");
            dt.Columns.Add("KayitTarihi");
            dt.Columns.Add("ÖrnekAlmaTarihi");

            
            for (int i = 0; i < hs.Length; i++)
            {

                dt.Rows.Add(hs[i].TestSonuclariGenel[0].Aciklama, hs[i].TestSonuclariGenel[0].AdiSoyadi, hs[i].TestSonuclariGenel[0].AileHekimiAdi, hs[i].TestSonuclariGenel[0].BabaAdi, hs[i].TestSonuclariGenel[0].Barkod, hs[i].TestSonuclariGenel[0].BirimAdi, hs[i].TestSonuclariGenel[0].DogumTarihi, hs[i].TestSonuclariGenel[0].KayitTarihi, hs[i].TestSonuclariGenel[0].OrnekAlmaTarihi);
            }
            dataGridView1.DataSource=dt;

            

        
        }

   

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili_alan = dataGridView1.SelectedCells[0].RowIndex;
            string barkod = dataGridView1.Rows[secili_alan].Cells[4].Value.ToString();
            textBox2.Text = barkod;
            textBox2.ReadOnly = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ws_Adana_Lab_Entegre.EntegreLBYSLabService servis = new ws_Adana_Lab_Entegre.EntegreLBYSLabService();

            ws_Adana_Lab_Entegre.HastaSonucToplu[] hs = servis.TCSonucBilgisi("21805034564", "2164", "11584398278");

            DataTable dt1 = new DataTable();
            dt1.Columns.Add("OrnekTipi");
            dt1.Columns.Add("Sonuc");
            dt1.Columns.Add("SonucAciklama");
            dt1.Columns.Add("SonucBirim");
            dt1.Columns.Add("SonucDurum");
            dt1.Columns.Add("SonucOnayTarihi", typeof(System.DateTime));
            dt1.Columns.Add("SonucReferans");
            dt1.Columns.Add("SonucYorum");
            dt1.Columns.Add("TestAdi");
            dt1.Columns.Add("TestGrupAdi");
            dt1.Columns.Add("TestID");
            dt1.Columns.Add("TestParametreAdi");

            for (int i = 0; i < hs[0].TestSonuclariGenel[0].TestSonuclari.Length; i++)
            {

                dt1.Rows.Add(hs[0].TestSonuclariGenel[0].TestSonuclari[i].OrnekTipi, hs[0].TestSonuclariGenel[0].TestSonuclari[i].Sonuc, hs[0].TestSonuclariGenel[0].TestSonuclari[i].SonucAciklama, hs[0].TestSonuclariGenel[0].TestSonuclari[i].SonucBirim, hs[0].TestSonuclariGenel[0].TestSonuclari[i].SonucDurum, hs[0].TestSonuclariGenel[0].TestSonuclari[i].SonucOnayTarihi, hs[0].TestSonuclariGenel[0].TestSonuclari[i].SonucReferans, hs[0].TestSonuclariGenel[0].TestSonuclari[i].SonucYorum, hs[0].TestSonuclariGenel[0].TestSonuclari[i].TestAdi, hs[0].TestSonuclariGenel[0].TestSonuclari[i].TestGrupAdi, hs[0].TestSonuclariGenel[0].TestSonuclari[i].TestID, hs[0].TestSonuclariGenel[0].TestSonuclari[i].TestParametreAdi);
            }
           
        }
    }
}
