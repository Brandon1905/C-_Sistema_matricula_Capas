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
using SistemaMatricula.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class ModuloAula : Form
    {
        DataSet dsAula = new DataSet();
        DataTable dtAula = new DataTable();
        private int Aula_id = 0;
        public ModuloAula()
        {
            InitializeComponent();
        }

        private void Aula_Load(object sender, EventArgs e)
        {
            CargarGridAula();
            CargarComboAula();
        }

        private void CargarGridAula()
        {
            using (GestorAula elAula = new GestorAula())
            {
                dgvAula.DataSource = elAula.ListarAula();
            }
            dgvAula.Columns["Aula_id"].Visible = false;
            dgvAula.Columns["Aula_descripcion"].HeaderText = "Descripcion";
            dgvAula.Columns["Aula_capacidad"].HeaderText = "Capacidad";
            dgvAula.Columns["Aula_estado"].Visible = false;
        }

        private void CargarComboAula()
        {
            using (GestorAula elAula = new GestorAula())
            {
                cbxAula.DataSource = elAula.ListarAula();

                cbxAula.ValueMember = "Aula_id";
                cbxAula.DisplayMember = "Aula_descripcion";
            }
        }

        private void BuscarAula()
        {
            Aula_id = int.Parse(cbxAula.SelectedValue.ToString());
            using (GestorAula Aula = new GestorAula())
            {
                this.dsAula = Aula.ConsultarAula(Aula_id);
                this.dtAula = this.dsAula.Tables[0];
            }
            CargarDatosAula();
        }

        private void CargarDatosAula()
        {
            txtAula_descripcion.Text = this.dtAula.Rows[0]["Aula_descripcion"].ToString();
            txtAula_capacidad.Text = this.dtAula.Rows[0]["Aula_capacidad"].ToString();
        }


        //--------------------------------------------------------------------


        private void dgvAula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dgvAula.CurrentCell.RowIndex;
                Aula_id = int.Parse(this.dgvAula[0, numFila].Value.ToString());

                using (GestorAula elAula = new GestorAula())
                {
                    this.dsAula = elAula.ConsultarAula(Aula_id);
                    this.dtAula = this.dsAula.Tables[0];

                }
                CargarDatosAula();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. ingrese datos", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarAula();
        }

        private void btnAula_Modificar_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.ModificarAula(Aula_id, txtAula_descripcion.Text, txtAula_capacidad.Text, "A");
            }

            CargarGridAula();
            CargarComboAula();
        }

        private void btnAula_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.InsertarAula(txtAula_descripcion.Text, txtAula_capacidad.Text, "A");
            }
            Aula_id = 0;
            CargarGridAula();
            CargarComboAula();
        }

        private void btnReporteProfesor_Click(object sender, EventArgs e)
        {
            FrmReporteAula resporte = new FrmReporteAula();
            resporte.Show();
        }
    }
}
