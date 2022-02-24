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
    public partial class frmEcrivains : Form
    {
        public frmEcrivains()
        {
            InitializeComponent();
        }

        private void eCRIVAINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eCRIVAINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librairieDataSet);

        }

        private void frmEcrivains_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'librairieDataSet.ECRIVAIN'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.eCRIVAINTableAdapter.Fill(this.librairieDataSet.ECRIVAIN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstEcrivains cr = new lstEcrivains();
            cr.SetDataSource(librairieDataSet);
            frmImpression f = new frmImpression(cr);
            f.ShowDialog();
        }
    }
}
