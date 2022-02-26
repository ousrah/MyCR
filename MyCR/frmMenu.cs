using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyCR
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOuvages f = new frmOuvages();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEcrivains f = new frmEcrivains();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEditeurs f = new frmEditeurs();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmClassifications f = new frmClassifications();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lstOuvragesParClassification cr = new lstOuvragesParClassification();
            cr.SetDatabaseLogon("sa", "P@ssw0rd");
            frmImpression f = new frmImpression(cr);
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GraphNbOuvragesParclassification cr = new GraphNbOuvragesParclassification();
            cr.SetDatabaseLogon("sa", "P@ssw0rd");
            frmImpression f = new frmImpression(cr);
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           nbOuvragesParEditeur cr = new nbOuvragesParEditeur();
            cr.SetDatabaseLogon("sa", "P@ssw0rd");
            frmImpression f = new frmImpression(cr);
            f.ShowDialog();
        }
    }
}
