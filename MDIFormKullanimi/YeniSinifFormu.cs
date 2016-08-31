using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIFormKullanimi
{
    public partial class YeniSinifFormu : Form
    {
        public YeniSinifFormu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=DESKTOP-ADS5CUN\\SQLEXPRESS; database=wn11; integrated security=true");
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert Classes values(@name, @number)", con);
            kaydet.Parameters.AddWithValue("@number",nudCapacity.Value);
            kaydet.Parameters.AddWithValue("@name", txtName.Text);

            con.Open();
            kaydet.ExecuteNonQuery();
            con.Close();

            txtName.Clear();
            nudCapacity.Value = nudCapacity.Minimum;
        }

        private void YeniSinifFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
