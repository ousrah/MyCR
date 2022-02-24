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
    public partial class frmClassifications : Form
    {    DataSet ds = new DataSet();   
        BindingSource bs = new BindingSource();
        public frmClassifications()
        {
            InitializeComponent();
        }

        private void frmClassifications_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"data source=.\sqlexpress2008;initial catalog=librairie;user id=sa;Password=P@ssw0rd");
            cn.Open();
            SqlCommand com = new SqlCommand("select * from classification", cn);
        
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(ds, "classification");

   
            bs.DataMember = "classification";
            bs.DataSource = ds;
            listBox1.DisplayMember = "librub";
            listBox1.ValueMember = "numrub";
            listBox1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            lstClassifications cr = new lstClassifications();
            cr.SetDataSource(ds);
            string filtre = "{classification.librub} like '*"+txtRecherche.Text+"*'";
            frmImpression f = new frmImpression(cr,filtre);
            f.ShowDialog();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            bs.Filter = "librub like '%"+txtRecherche.Text+"%'";
        }
    }
}
