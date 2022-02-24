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
    }
}
