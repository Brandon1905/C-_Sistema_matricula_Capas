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
    public partial class ModuloGrupo : Form
    {
        DataSet dsGrupo = new DataSet();
        DataTable dtGrupo = new DataTable();
        private int Grupo_id = 0;

        public ModuloGrupo()
        {
            InitializeComponent();
        }

        private void ModuloGrupo_Load(object sender, EventArgs e)
        {
            CargarGridGrupo();
            CargarComboGrupo();
        }

        private void CargarGridGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                dgvGrupo.DataSource = elGrupo.ListarGrupo();
                   
                dgvGrupo.Columns["Grupo_id"].Visible = false;
                dgvGrupo.Columns["Grupo_descripcion"].HeaderText = "Descripcion";
                dgvGrupo.Columns["Grupo_estado"].Visible = false;
            }
        }

        private void CargarComboGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                cbxGrupo.DataSource = elGrupo.ListarGrupo();
                   
                cbxGrupo.ValueMember = "Grupo_id";
                cbxGrupo.DisplayMember = "Grupo_descripcion";
            }
        }

        private void BuscarGrupo()
        {
            Grupo_id = int.Parse(cbxGrupo.SelectedValue.ToString());
            using (GestorGrupo Grupo = new GestorGrupo())
            {
                this.dsGrupo = Grupo.ConsultarGrupo(Grupo_id);
                this.dtGrupo = this.dsGrupo.Tables[0];
            }
            CargarDatosGrupo();
        }

        private void CargarDatosGrupo()
        {
            txtgrupo_descripcion.Text = this.dtGrupo.Rows[0]["Grupo_descripcion"].ToString();
        }


        //--------------------------------------------------------------------


        private void dgvGrupo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dgvGrupo.CurrentCell.RowIndex;
                Grupo_id = int.Parse(this.dgvGrupo[0, numFila].Value.ToString());

                using (GestorGrupo elGrupo = new GestorGrupo())
                {
                    this.dsGrupo = elGrupo.ConsultarGrupo(Grupo_id);
                    this.dtGrupo = this.dsGrupo.Tables[0];

                }
                CargarDatosGrupo();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. ingrese datos", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarGrupo();
        }

        private void btnGrupo_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                elGrupo.InsertarGrupo(txtgrupo_descripcion.Text, "A");
            }
            Grupo_id = 0;
            CargarGridGrupo();
            CargarComboGrupo();
        }

        private void btnGrupo_Modificar_Click(object sender, EventArgs e)
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                elGrupo.ModificarGrupo(Grupo_id, txtgrupo_descripcion.Text, "A");
            }

            CargarGridGrupo();
            CargarComboGrupo();
        }

        private void btnReporteProfesor_Click(object sender, EventArgs e)
        {
            FrmReporteGrupo resporte = new FrmReporteGrupo();
            resporte.Show();
        }
    }
}
