using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail; 
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class sifre_yenileme : Form
    {
        SqlConnection conn = new SqlConnection("Data Source= LAPTOP-3KQM3JF1\\SQLEXPRESS; Initial Catalog=Bitirme-projesi; Integrated Security=true");
        public sifre_yenileme()
        {
            InitializeComponent();
        }

        private void sifre_yenileme_Load(object sender, EventArgs e)
        {

        }
    }
}
