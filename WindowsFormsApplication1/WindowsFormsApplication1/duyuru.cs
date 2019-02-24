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
    public partial class duyuru : Form
    {
        public duyuru()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source= LAPTOP-3KQM3JF1\\SQLEXPRESS; Initial Catalog=Duyurular; Integrated Security=true");
        private void duyuru_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            conn.Close();

            conn.Open();
            ws_Adana_Lab_Entegre.LiosService servis = new ws_Adana_Lab_Entegre.LiosService();
            ws_Adana_Lab_Entegre.Duyurular[] duyuru = servis.DuyurulariGetir("21805034564", "2164");
            int boyut = duyuru.Length;
            int ds = boyut - 10;//duyuru sayısı
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM duyuru", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                SqlCommand sil = new SqlCommand("DELETE duyuru", conn);
                sil.ExecuteNonQuery();

            }

            for (int i = 0; i <100; i++)
            {
                SqlCommand cmdTetkikInsert = new SqlCommand(@"INSERT INTO duyuru(duyuruID,baslik,icerik) VALUES(@id,@bas,@ic)", conn);

                cmdTetkikInsert.Parameters.Add("@id", SqlDbType.VarChar).Value = duyuru[i].DuyuruID;
                cmdTetkikInsert.Parameters.Add("@bas", SqlDbType.VarChar).Value = duyuru[i].Baslik;
                cmdTetkikInsert.Parameters.Add("@ic", SqlDbType.VarChar).Value = duyuru[i].Icerik;

                cmdTetkikInsert.ExecuteNonQuery();


            }
            conn.Close();
            conn.Open();
            DataTable kn = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("select   distinct  baslik,icerik from duyuru", conn);
            adaptor.Fill(kn);
            gridControl1.DataSource = kn;
        }

       
    }
}
