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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblPuesto_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtSalario.Text) || cboBoxPuesto.SelectedItem == null || (numericUpDownEdad.Value < 18))
            
                return;

                ListViewItem item = new ListViewItem(txtID.Text);
                item.SubItems.Add(txtNombre.Text);
                item.SubItems.Add(txtApellido.Text);
                item.SubItems.Add(numericUpDownEdad.Value.ToString());

                string dobleTurno;
                dobleTurno = checkBoxDobleTurno.Checked ? "True" : "False";
                item.SubItems.Add(dobleTurno);


                string genero;
                if (rdBtnHombre.Checked)
                    genero = rdBtnHombre.Text;
                else if (rdBtnMujer.Checked)
                    genero = rdBtnMujer.Text;
                else
                    genero = rdBtnNoBin.Text;

                item.SubItems.Add(genero);
                item.SubItems.Add(cboBoxPuesto.SelectedItem.ToString());
                item.SubItems.Add(txtSalario.Text);
                item.SubItems.Add(txtTelefono.Text);
                listView1.Items.Add(item);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboBoxPuesto.Items.Add("CEO");
            cboBoxPuesto.Items.Add("Desarrollador");
            cboBoxPuesto.Items.Add("Tester");
            cboBoxPuesto.Items.Add("Analista");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[3]);

        }
    }
}
