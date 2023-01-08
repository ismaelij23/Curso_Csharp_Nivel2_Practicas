using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboBoxColorFav.Items.Add("Negro");
            cboBoxColorFav.Items.Add("Azul Marino");
            cboBoxColorFav.Items.Add("Amarillo");
            cboBoxColorFav.Items.Add("Violeta");
        }

        private void btnAgrPersona_Click(object sender, EventArgs e)
        {
            Perfil per1 = new Perfil();
            per1.Nombre = textName.Text;
            per1.FechaNac = dtpFechaNto.Value;
            per1.Chocolate = chBoxChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";

            if (radBtnHombre.Checked)
                per1.Genero = radBtnHombre.Text;
            else if (radBtnHombre.Checked)
                per1.Genero = radBtnHombre.Text;
            else
                per1.Genero = radBtnNoBin.Text;

            per1.ColorFav = cboBoxColorFav.SelectedItem.ToString();
            per1.NumFav = numericUpDown1.Value.ToString();

            MessageBox.Show(per1.presentacion());
            listView.Items.Add(per1.presentacion());
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cboBoxColorFav_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
