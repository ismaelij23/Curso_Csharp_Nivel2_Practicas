using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCualca
{
    public partial class frmPrinc : Form
    {
        public frmPrinc()
        {
            InitializeComponent();
        }

        private void perfilPersonaMenu_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            //ventana.Show();
            ventana.ShowDialog();   
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            //ventana.Show();
            ventana.ShowDialog();
        }
    }
}
