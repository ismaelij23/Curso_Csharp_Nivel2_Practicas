using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Practica_1_BD
{
    public partial class FormDiscos : Form
    {
        private List<Disco> listaDisco;
        private List<Estilo> listaEstilo;
        public FormDiscos()
        {
            InitializeComponent();
        }

        private void FormDiscos_Load(object sender, EventArgs e)
        {
            //Carga de los datos de los Discos en el dgvDiscos
            DiscosDatos datos = new DiscosDatos();
            listaDisco = datos.listar();
            dgvDiscos.DataSource = listaDisco;
            dgvDiscos.Columns["UrlImagen"].Visible = false;
            cargarImagen(listaDisco[0].UrlImagen);

            //Carga de los datos de los Estilos en el dgvEstilos
            EstilosDatos datosEstilos = new EstilosDatos();
            listaEstilo = datosEstilos.listar();
            dgvEstilos.DataSource = listaEstilo;
            dgvEstilos.Columns["Id"].Visible = false;
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxDisco.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxDisco.Load("https://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif");
            }
        }

        private void dgvDiscos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrnAltaDisco alta = new FrnAltaDisco();
            alta.ShowDialog();
        }
    }
}
