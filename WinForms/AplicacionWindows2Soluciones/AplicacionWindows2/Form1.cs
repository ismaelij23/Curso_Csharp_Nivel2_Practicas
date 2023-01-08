using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindows2
{
    public partial class DatosPersonalesForm : Form
    {
        public DatosPersonalesForm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "") 
                txtNombre.BackColor = Color.Red;
            if(txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            if(txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            if(txtDireccion.Text == "")
                txtDireccion.BackColor= Color.Red;
            
            if(txtNombre.Text != "" && txtApellido.Text != "" && txtEdad.Text != "" && txtDireccion.Text != "")
            {
                txtResultado.Text = "APELLIDO Y NOMBRE: " + txtApellido.Text + " " + txtNombre.Text + "\r\n" + "EDAD: " + txtEdad.Text + "\r\n" + "DIRECCIÓN: " + txtDireccion.Text;
                
            }
        }

        private void DatosPersonalesForm_Load(object sender, EventArgs e)
        {

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
