using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace MyCR
{
    public partial class frmImpression : Form
    {
        ReportClass cr;
        string filtre;
        public frmImpression()
        {
            InitializeComponent();
        }

        public frmImpression(ReportClass cr, string filtre="")
        {
            this.cr = cr;
            this.filtre = filtre;
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'librairieDataSet.OUVRAGE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
             crv.ReportSource = cr;
               crv.SelectionFormula = filtre;
        }
    }
}
