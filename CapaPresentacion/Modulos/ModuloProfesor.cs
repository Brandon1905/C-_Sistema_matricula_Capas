using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMatricula.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class frmProfesor : Form
    {
        DataSet dsProfesor = new DataSet();
        DataTable dtProfesor = new DataTable();
        private int Profesor_id = 0;

        public frmProfesor()
        {
            InitializeComponent();
        }

        private void frmProfesor_Load(object sender, EventArgs e)
        {
            CargarGridProfesor();
            CargarComboProfesor();
        }

        private void CargarGridProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                dgvProfesores.DataSource = elProfesor.ListarProfesor();

                dgvProfesores.Columns["Profesor_id"].Visible = false;
                dgvProfesores.Columns["Profesor_cedula"].HeaderText = "Cedula";
                dgvProfesores.Columns["Profesor_nombre"].HeaderText = "Nombre";
                dgvProfesores.Columns["Profesor_primerApellido"].HeaderText = "Primer Apellido";
                dgvProfesores.Columns["Profesor_segundoApellido"].HeaderText = "Segundo Apellido";
                dgvProfesores.Columns["Profesor_telefono"].HeaderText = "Telefono";
                dgvProfesores.Columns["Profesor_correoElectronico"].HeaderText = "Correo Electronico";
                dgvProfesores.Columns["Profesor_direccion"].HeaderText = "Direccion";
                dgvProfesores.Columns["Profesor_estado"].Visible = false;
            }
        }

        private void CargarComboProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                cbxProfesor.DataSource = elProfesor.ListarProfesor();

                cbxProfesor.ValueMember = "Profesor_id";
                cbxProfesor.DisplayMember = "Profesor_cedula";
            }
        }

        private void BuscarProfesor()
        {
            Profesor_id = int.Parse(cbxProfesor.SelectedValue.ToString());
            using (GestorProfesor Profesor = new GestorProfesor())
            {
                this.dsProfesor = Profesor.ConsultarProfesor(Profesor_id);
                this.dtProfesor = this.dsProfesor.Tables[0];
            }
            CargarDatosProfesor();
        }

        private void CargarDatosProfesor()
        {
            txtProfesor_cedula.Text = this.dtProfesor.Rows[0]["Profesor_cedula"].ToString();
            txtProfesor_nombre.Text = this.dtProfesor.Rows[0]["Profesor_nombre"].ToString();
            txtProfesor_primerApellido.Text = this.dtProfesor.Rows[0]["Profesor_primerApellido"].ToString();
            txtProfesor_segundoApellido.Text = this.dtProfesor.Rows[0]["Profesor_segundoApellido"].ToString();
            txtProfesor_telefono.Text = this.dtProfesor.Rows[0]["Profesor_telefono"].ToString();
            txtProfesor_correoElectronico.Text = this.dtProfesor.Rows[0]["Profesor_correoElectronico"].ToString();
            txtProfesor_direccion.Text = this.dtProfesor.Rows[0]["Profesor_direccion"].ToString();
        }


        //--------------------------------------------------------------------


        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dgvProfesores.CurrentCell.RowIndex;
                Profesor_id = int.Parse(this.dgvProfesores[0, numFila].Value.ToString());

                using (GestorProfesor elProfesor = new GestorProfesor())
                {
                    this.dsProfesor = elProfesor.ConsultarProfesor(Profesor_id);
                    this.dtProfesor = this.dsProfesor.Tables[0];

                }
                CargarDatosProfesor();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. ingrese datos", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarProfesor();
        }

        private void btnProfesor_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elprofesor = new GestorProfesor())
            {
                elprofesor.InsertarProfesor(txtProfesor_cedula.Text, txtProfesor_nombre.Text, txtProfesor_primerApellido.Text,
                    txtProfesor_segundoApellido.Text, txtProfesor_telefono.Text, txtProfesor_correoElectronico.Text,
                    txtProfesor_direccion.Text, "A");
            }
            Profesor_id = 0;
            CargarGridProfesor();
            CargarComboProfesor();
        }

        private void btnProfesor_Modificar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                elProfesor.ModificarProfesor(Profesor_id, txtProfesor_cedula.Text, txtProfesor_nombre.Text, txtProfesor_primerApellido.Text, txtProfesor_segundoApellido.Text,
                                            txtProfesor_telefono.Text, txtProfesor_correoElectronico.Text, txtProfesor_direccion.Text, "A");
            }

            CargarGridProfesor();
            CargarComboProfesor();
        }

        private void btnReporteProfesor_Click(object sender, EventArgs e)
        {
            FrmReporteProfesror resporte = new FrmReporteProfesror();
            resporte.Show();
        }
    }
}
