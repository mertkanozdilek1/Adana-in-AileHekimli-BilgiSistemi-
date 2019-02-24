using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Tcilesonuc : Form
    {
        public Tcilesonuc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ws_Adana_Lab_Entegre.LiosService servis = new ws_Adana_Lab_Entegre.LiosService();

            ws_Adana_Lab_Entegre.HastaSonucToplu[] hs = servis.TCSonucBilgisi("21805034564", "2164", textBox1.Text);
        
            

            DataTable dt = new DataTable();
            dt.Columns.Add("Aciklama");
            dt.Columns.Add("AdiSoyadi");
            dt.Columns.Add("AileHekimiAdi");
            dt.Columns.Add("BabaAdi");
            dt.Columns.Add("Barkod");
            dt.Columns.Add("BirimAdi");
            dt.Columns.Add("DogumTarihi");
            dt.Columns.Add("KayitTarihi");
           

            for (int i = 0; i < hs.Length; i++)
            {

                dt.Rows.Add(hs[i].TestSonuclariGenel[0].Aciklama, hs[i].TestSonuclariGenel[0].AdiSoyadi, hs[i].TestSonuclariGenel[0].AileHekimiAdi, hs[i].TestSonuclariGenel[0].BabaAdi, hs[i].TestSonuclariGenel[0].Barkod, hs[i].TestSonuclariGenel[0].BirimAdi, hs[i].TestSonuclariGenel[0].DogumTarihi, hs[i].TestSonuclariGenel[0].KayitTarihi);
            }
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili_alan = dataGridView1.SelectedCells[0].RowIndex;
            string barkod = dataGridView1.Rows[secili_alan].Cells[4].Value.ToString();
            textBox2.Text = barkod;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ws_Adana_Lab_Entegre.LiosService servis = new ws_Adana_Lab_Entegre.LiosService();

            ws_Adana_Lab_Entegre.HastaSonucBilgisi[] HastaSonuc = servis.BarkodSonucBilgisi(textBox2.Text, "21805034564", "2164");
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("OrnekTipi");
            dt2.Columns.Add("Sonuc");
            dt2.Columns.Add("SonucAciklama");
            dt2.Columns.Add("SonucBirim");
            dt2.Columns.Add("SonucDurum");
            dt2.Columns.Add("SonucOnayTarihi", typeof(System.DateTime));
            dt2.Columns.Add("SonucReferans");
            dt2.Columns.Add("SonucYorum");
            dt2.Columns.Add("TestAdi");
            dt2.Columns.Add("TestGrupAdi");
            dt2.Columns.Add("TestID");
            dt2.Columns.Add("TestParametreAdi");
            if (HastaSonuc[0].TestSonuclari.Length == 0)
                MessageBox.Show("Barkoda Ait Test Sonucu Bulunamamıştır");

            else
            {
                for (int i = 0; i < HastaSonuc[0].TestSonuclari.Length; i++)
                {
                    dt2.Rows.Add(HastaSonuc[0].TestSonuclari[i].OrnekTipi, HastaSonuc[0].TestSonuclari[i].Sonuc, HastaSonuc[0].TestSonuclari[i].SonucAciklama, HastaSonuc[0].TestSonuclari[i].SonucBirim, HastaSonuc[0].TestSonuclari[i].SonucDurum, HastaSonuc[0].TestSonuclari[i].SonucOnayTarihi, HastaSonuc[0].TestSonuclari[i].SonucReferans, HastaSonuc[0].TestSonuclari[i].SonucYorum, HastaSonuc[0].TestSonuclari[i].TestAdi, HastaSonuc[0].TestSonuclari[i].TestGrupAdi, HastaSonuc[0].TestSonuclari[i].TestID, HastaSonuc[0].TestSonuclari[i].TestParametreAdi);

                    gridControl1.DataSource = dt2;
                }
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
