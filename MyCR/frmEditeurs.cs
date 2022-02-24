using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyCR
{
    public partial class frmEditeurs : Form
    {
        public frmEditeurs()
        {
            InitializeComponent();
        }

        private void frmEditeurs_Load(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(@"data source=.\sqlexpress2008;initial catalog=librairie;user id=sa;Password=P@ssw0rd");
            cn.Open();
            SqlCommand com = new SqlCommand("select * from editeur", cn);
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            listBox1.DisplayMember = "nomed";
            listBox1.ValueMember = "nomed";
            listBox1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstEditeur cr = new lstEditeur();
            cr.SetDatabaseLogon("sa", "P@ssw0rd");
            frmImpression f = new frmImpression(cr);
            f.ShowDialog();
        }
    }
}
