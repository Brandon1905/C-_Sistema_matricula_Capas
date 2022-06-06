using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaIntegracion;
using CapaPresentacion.Reportes;

namespace CapaPresentacion
{
    public partial class ModuloEstudiante : Form
    {
        DataSet dsEstudiante = new DataSet();
        DataTable dtEstudiante = new DataTable();
        private int Estudiante_id = 0;

        public ModuloEstudiante()
        {
            InitializeComponent();
        }

        private void ModuloEstudiante_Load(object sender, EventArgs e)
        {
            CargarGridEstudiante();
            CargarComboEstudiante();
        }

        private void CargarGridEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                dgvEstudiante.DataSource = elEstudiante.ListarEstudiante();
                   
                dgvEstudiante.Columns["Estudiante_id"].Visible = false;
                dgvEstudiante.Columns["Grupo_id"].HeaderText = "Grupo";
                dgvEstudiante.Columns["Estudiante_cedula"].HeaderText = "Cedula";
                dgvEstudiante.Columns["Estudiante_nombre"].HeaderText = "Nombre";
                dgvEstudiante.Columns["Estudiante_primerApellido"].HeaderText = "Primer Apellido";
                dgvEstudiante.Columns["Estudiante_segundoApellido"].HeaderText = "Segundo Apellido";
                dgvEstudiante.Columns["Estudiante_telefono"].HeaderText = "Telefono";
                dgvEstudiante.Columns["Estudiante_correoElectronico"].HeaderText = "Correo Electronico";
                dgvEstudiante.Columns["Estudiante_direccion"].HeaderText = "Direccion";
                dgvEstudiante.Columns["Estudiante_estado"].Visible = false;
            }
        }

        private void CargarComboEstudiante()
        {
            using (GestorEstudiante elProfesor = new GestorEstudiante())
            {
                cbxEstudiante.DataSource = elProfesor.ListarEstudiante();
                   
                cbxEstudiante.ValueMember = "Estudiante_id";
                cbxEstudiante.DisplayMember = "Estudiante_cedula";
            }
        }

        private void BuscarEstudiante()
        {
            Estudiante_id = int.Parse(cbxEstudiante.SelectedValue.ToString());
            using (GestorEstudiante Estudiante = new GestorEstudiante())
            {
                this.dsEstudiante = Estudiante.ConsultarEstudiante(Estudiante_id);
                this.dtEstudiante = this.dsEstudiante.Tables[0];
            }
            CargarDatosEstudiante();
        }

        private void CargarDatosEstudiante()
        {
            txtEstudiante_Grupo.Text = this.dtEstudiante.Rows[0]["Grupo_id"].ToString();
            txtEstudiante_cedula.Text = this.dtEstudiante.Rows[0]["Estudiante_cedula"].ToString();
            txtEstudiante_nombre.Text = this.dtEstudiante.Rows[0]["Estudiante_nombre"].ToString();
            txtEstudiante_primerApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_primerApellido"].ToString();
            txtEstudiante_segundoApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_segundoApellido"].ToString();
            txtEstudiante_telefono.Text = this.dtEstudiante.Rows[0]["Estudiante_telefono"].ToString();
            txtEstudiante_correoElectronico.Text = this.dtEstudiante.Rows[0]["Estudiante_correoElectronico"].ToString();
            txtEstudiante_direccion.Text = this.dtEstudiante.Rows[0]["Estudiante_direccion"].ToString();
        }


        //--------------------------------------------------------------------


        private void dgvEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dgvEstudiante.CurrentCell.RowIndex;
                Estudiante_id = int.Parse(this.dgvEstudiante[0, numFila].Value.ToString());

                using (GestorEstudiante elEstudiante = new GestorEstudiante())
                {
                    this.dsEstudiante = elEstudiante.ConsultarEstudiante(Estudiante_id);
                    this.dtEstudiante = this.dsEstudiante.Tables[0];

                }
                CargarDatosEstudiante();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. ingrese datos", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarEstudiante();
        }

        private void btnEstudiante_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                elEstudiante.InsertarEstudiante(int.Parse(txtEstudiante_Grupo.Text), txtEstudiante_cedula.Text, txtEstudiante_nombre.Text, txtEstudiante_primerApellido.Text,
                    txtEstudiante_segundoApellido.Text, txtEstudiante_telefono.Text, txtEstudiante_correoElectronico.Text, txtEstudiante_direccion.Text, "A");
            }
            Estudiante_id = 0;
            CargarGridEstudiante();
            CargarComboEstudiante();
        }

        private void btnEstudiante_Modificar_Click(object sender, EventArgs e)
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                elEstudiante.ModificarEstudiante(Estudiante_id, int.Parse(txtEstudiante_Grupo.Text), txtEstudiante_cedula.Text, txtEstudiante_nombre.Text, txtEstudiante_primerApellido.Text,
                    txtEstudiante_segundoApellido.Text, txtEstudiante_telefono.Text, txtEstudiante_correoElectronico.Text, txtEstudiante_direccion.Text, "A");
            }
            CargarGridEstudiante();
            CargarComboEstudiante();
        }

        private void dgvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReporteProfesor_Click(object sender, EventArgs e)
        {
            FrmReporteEstudiante resporte = new FrmReporteEstudiante();
            resporte.Show();
        }
    }
}
