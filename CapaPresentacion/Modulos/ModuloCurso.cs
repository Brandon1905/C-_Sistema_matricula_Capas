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
    public partial class ModuloCurso : Form
    {
        DataSet dsCurso = new DataSet();
        DataTable dtCurso = new DataTable();
        private int Curso_id = 0;

        public ModuloCurso()
        {
            InitializeComponent();
        }

        private void ModuloCurso_Load(object sender, EventArgs e)
        {
            CargarGridCurso();
            CargarComboCurso();
        }

        private void CargarGridCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                dgvCurso.DataSource = elCurso.ListarCurso();

                dgvCurso.Columns["Curso_id"].Visible = false;
                dgvCurso.Columns["Curso_nombre"].HeaderText = "Nombre";
                dgvCurso.Columns["Curso_creditos"].HeaderText = "Creditos";
                dgvCurso.Columns["Curso_cupo"].HeaderText = "Cupo";
                dgvCurso.Columns["Curso_estado"].Visible = false;
            }
        }

        private void CargarComboCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                cbxCurso.DataSource = elCurso.ListarCurso();

                cbxCurso.ValueMember = "Curso_id";
                cbxCurso.DisplayMember = "Curso_nombre";
            }
        }

        private void BuscarCurso()
        {
            Curso_id = int.Parse(cbxCurso.SelectedValue.ToString());
            using (GestorCurso Curso = new GestorCurso())
            {
                this.dsCurso = Curso.ConsultarCurso(Curso_id);
                this.dtCurso = this.dsCurso.Tables[0];
            }
            CargarDatosCurso();
        }

        private void CargarDatosCurso()
        {          
            txtCurso_nombre.Text = this.dtCurso.Rows[0]["Curso_nombre"].ToString();
            txtCurso_Creditos.Text = this.dtCurso.Rows[0]["Curso_creditos"].ToString();
            txtCurso_Cupo.Text = this.dtCurso.Rows[0]["Curso_cupo"].ToString();
        }


        //--------------------------------------------------------------------


        private void dgvCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dgvCurso.CurrentCell.RowIndex;
                Curso_id = int.Parse(this.dgvCurso[0, numFila].Value.ToString());

                using (GestorCurso elCurso = new GestorCurso())
                {
                    this.dsCurso = elCurso.ConsultarCurso(Curso_id);
                    this.dtCurso = this.dsCurso.Tables[0];

                }
                CargarDatosCurso();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. ingrese datos", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarCurso();
        }

        private void btnCurso_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                elCurso.InsertarCurso(txtCurso_nombre.Text, txtCurso_Creditos.Text, txtCurso_Cupo.Text, "A");
            }
            Curso_id = 0;
            CargarGridCurso();
            CargarComboCurso();
        }

        private void btnCurso_Modificar_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                elCurso.ModificarCurso(Curso_id, txtCurso_nombre.Text, txtCurso_Creditos.Text, txtCurso_Cupo.Text, "A");
            }

            CargarGridCurso();
            CargarComboCurso();
        }

        private void btnReporteProfesor_Click(object sender, EventArgs e)
        {
            FrmReporteCurso resporte = new FrmReporteCurso();
            resporte.Show();
        }
    }
}
