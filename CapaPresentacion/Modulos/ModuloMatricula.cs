using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Reportes;
using SistemaMatricula.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class ModuloMatricula : Form
    {
        DataSet dsMatricula = new DataSet();
        DataTable dtMatricula = new DataTable();
        private int Matricula_id = 0;

        public ModuloMatricula()
        {
            InitializeComponent();
        }

        private void ModuloMatricula_Load(object sender, EventArgs e)
        {
            CargarGridMatricula();
            CargarComboMatricula();
        }

        private void CargarGridMatricula()
        {
            using (GestorMatricula elMatricula = new GestorMatricula())
            {
                dgvMatricula.DataSource = elMatricula.ListarMatricula();

                dgvMatricula.Columns["Matricula_id"].Visible = false;
                dgvMatricula.Columns["Estudiante_id"].HeaderText = "Estudiante";
                dgvMatricula.Columns["Grupo_id"].HeaderText = "Grupo";
                dgvMatricula.Columns["Curso_id"].HeaderText = "Curso";
                dgvMatricula.Columns["Profesor_id"].HeaderText = "Profesor";
                dgvMatricula.Columns["Horario_id"].HeaderText = "Horario";
                dgvMatricula.Columns["Aula_id"].HeaderText = "Aula";
                dgvMatricula.Columns["Matricula_comprobante"].HeaderText = "Comprobante";
                dgvMatricula.Columns["Matricula_estado"].Visible = false;
            }
        }

        private void CargarComboMatricula()
        {
            using (GestorMatricula elMatricula = new GestorMatricula())
            {
                cbxMatricula.DataSource = elMatricula.ListarMatricula();
                
                cbxMatricula.ValueMember = "Matricula_id";
                cbxMatricula.DisplayMember = "Estudiante_id";
            }
        }

        private void BuscarMatricula()
        {
            Matricula_id = int.Parse(cbxMatricula.SelectedValue.ToString());
            using (GestorMatricula Matricula = new GestorMatricula())
            {
                this.dsMatricula = Matricula.ConsultarMatricula(Matricula_id);
                this.dtMatricula = this.dsMatricula.Tables[0];
            }
            CargarDatosMatricula();
        }

        private void CargarDatosMatricula()
        {
            txtMatricula_Estudiante_id.Text = this.dtMatricula.Rows[0]["Estudiante_id"].ToString();
            txtMatricula_Grupo_id.Text = this.dtMatricula.Rows[0]["Grupo_id"].ToString();
            txtMatricula_Curso_id.Text = this.dtMatricula.Rows[0]["Curso_id"].ToString();
            txtMatricula_Profesor_id.Text = this.dtMatricula.Rows[0]["Profesor_id"].ToString();
            txtMatricula_Horario_id.Text = this.dtMatricula.Rows[0]["Horario_id"].ToString();
            txtMatricula_Aula_id.Text = this.dtMatricula.Rows[0]["Aula_id"].ToString();
            txtMatricula_Comprobante.Text = this.dtMatricula.Rows[0]["Matricula_comprobante"].ToString();
         }


        //--------------------------------------------------------------------


        private void dgvMatricula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dgvMatricula.CurrentCell.RowIndex;
                Matricula_id = int.Parse(this.dgvMatricula[0, numFila].Value.ToString());

                using (GestorMatricula elEstudiante = new GestorMatricula())
                {
                    this.dsMatricula = elEstudiante.ConsultarMatricula(Matricula_id);
                    this.dtMatricula = this.dsMatricula.Tables[0];

                }
                CargarDatosMatricula();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. ingrese datos", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarMatricula();
        }

        private void btnMatricula_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorMatricula elMatricula = new GestorMatricula())
            {
                elMatricula.InsertarMatricula(int.Parse(txtMatricula_Estudiante_id.Text), int.Parse(txtMatricula_Grupo_id.Text), int.Parse(txtMatricula_Curso_id.Text), int.Parse(txtMatricula_Profesor_id.Text),
                    int.Parse(txtMatricula_Horario_id.Text), int.Parse(txtMatricula_Aula_id.Text), txtMatricula_Comprobante.Text, "A");
            }
            Matricula_id = 0;
            CargarGridMatricula();
            CargarComboMatricula();
        }

        private void btnMatricula_Modificar_Click(object sender, EventArgs e)
        {
            using (GestorMatricula elMatricula = new GestorMatricula())
            {
                elMatricula.ModificarMatricula(Matricula_id, int.Parse(txtMatricula_Estudiante_id.Text), int.Parse(txtMatricula_Grupo_id.Text), int.Parse(txtMatricula_Curso_id.Text), int.Parse(txtMatricula_Profesor_id.Text),
                    int.Parse(txtMatricula_Horario_id.Text), int.Parse(txtMatricula_Aula_id.Text), txtMatricula_Comprobante.Text, "A");
            }
            CargarGridMatricula();
            CargarComboMatricula();
        }

        private void btnReporteProfesor_Click(object sender, EventArgs e)
        {
            FrmReporteMatricula resporte = new FrmReporteMatricula();
            resporte.Show();
        }
    }
}
