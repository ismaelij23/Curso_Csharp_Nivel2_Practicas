using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDesafioWinForm
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido a C#");
        }

        private void formPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("chau chau...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atención compatriota");
            //this.BackColor = Color.Blue;


            //Se fija que Click del mouse presiono
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");

            if (txtDesafio.Text == "")
                txtDesafio.BackColor = Color.Red;
            else
                txtDesafio.BackColor = System.Drawing.SystemColors.Control;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.Red;
            label1.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.SystemColors.Control;
            label1.Cursor = Cursors.Arrow;
        }

        private void txtDesafio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDesafio1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtDesafio1.Text.Length + " Caracteres");
        }
    }
}
