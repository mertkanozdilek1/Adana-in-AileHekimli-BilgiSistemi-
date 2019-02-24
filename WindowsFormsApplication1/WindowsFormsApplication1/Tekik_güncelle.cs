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
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Tekik_güncelle : Form
    {
        public Tekik_güncelle()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source= LAPTOP-3KQM3JF1\\SQLEXPRESS; Initial Catalog=Tetkikler; Integrated Security=true");

        private void Tekik_güncelle_Load(object sender, EventArgs e)
        {

        }

     

    

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {

                conn.Close();
                conn.Open();
                ws_Adana_Lab_Entegre.LiosService servis = new ws_Adana_Lab_Entegre.LiosService();
                NetworkCredential netSGKCredential = new NetworkCredential("21805034564", "2164");
                servis.Credentials = netSGKCredential;
                  ws_Adana_Lab_Entegre.AktifTest[] testler = servis.AktifTestler("21805034564", "2164");


                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TETKIKLER", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    SqlCommand sil = new SqlCommand("DELETE TETKIKLER", conn);
                    sil.ExecuteNonQuery();

                }

                conn.Close();
                conn.Open();

                foreach (ws_Adana_Lab_Entegre.AktifTest Tetkik in testler)
                {


                    SqlCommand cmdTetkikInsert = new SqlCommand(@"INSERT INTO TETKIKLER(ReferansNo,TetkikAdi,TetkikKodu,GrupKodu,SUTTUT_NO,GUNCELLEME_TARIHI,AKTIF,GUNCELLEME_INFO) VALUES(@ReferansNo,@TetkikAdi,@TetkikKodu,@GrupKodu,@SUTTUT_NO,Getdate(),1,'Yeni Kayıt')", conn);

                    cmdTetkikInsert.Parameters.Add("@ReferansNo", SqlDbType.VarChar).Value = Tetkik.TestID;
                    cmdTetkikInsert.Parameters.Add("@TetkikAdi", SqlDbType.VarChar).Value = Tetkik.TestAdi;
                    cmdTetkikInsert.Parameters.Add("@TetkikKodu", SqlDbType.VarChar).Value = Tetkik.ButceKodu;
                    cmdTetkikInsert.Parameters.Add("@GrupKodu", SqlDbType.VarChar).Value = Tetkik.TestGrupAdi;
                    cmdTetkikInsert.Parameters.Add("@SUTTUT_NO", SqlDbType.VarChar).Value = Tetkik.ButceKodu;
                    cmdTetkikInsert.ExecuteNonQuery();



                }





                conn.Close();
                conn.Open();
                DataTable kn = new DataTable();
                SqlDataAdapter adaptor = new SqlDataAdapter("select * from TETKIKLER", conn);
                adaptor.Fill(kn);
                gridControl1.DataSource = kn;


                conn.Close();
            }



            catch
            { conn.Close(); }

            MessageBox.Show("TETKİK KAYDETME BAŞARILI");



        }

        }
    }
        
