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
    public partial class frmOuvages : Form
    {
        public frmOuvages()
        {
            InitializeComponent();
        }

        private void oUVRAGEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oUVRAGEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librairieDataSet);

        }

        private void frmOuvages_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'librairieDataSet.OUVRAGE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.oUVRAGETableAdapter.Fill(this.librairieDataSet.OUVRAGE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstOuvrages cr = new lstOuvrages();
            cr.SetDataSource(librairieDataSet);

            frmImpression f = new frmImpression(cr);
            f.ShowDialog();        
        }
    }
}
