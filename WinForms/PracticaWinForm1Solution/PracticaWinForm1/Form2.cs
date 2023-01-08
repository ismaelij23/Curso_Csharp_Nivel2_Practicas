using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaWinForm1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cargaDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya hay una ventana abierta");
                    return;
                }
            }

            Form1 ventanaPerfiles = new Form1();
            ventanaPerfiles.MdiParent = this;
            ventanaPerfiles.Show();
        }
    }
}
