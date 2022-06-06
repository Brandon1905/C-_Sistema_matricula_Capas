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
    public partial class ModeloHorario : Form
    {
        DataSet dsHorario = new DataSet();
        DataTable dtHorario = new DataTable();
        private int Horario_id = 0;

        public ModeloHorario()
        {
            InitializeComponent();
        }

        private void ModeloHorario_Load(object sender, EventArgs e)
        {
            CargarGridHorario();
            CargarComboHorario();
        }

        private void CargarGridHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                dgvHorario.DataSource = elHorario.ListarHorario();

                dgvHorario.Columns["Horario_id"].Visible = false;
                dgvHorario.Columns["Horario_descripcion"].HeaderText = "Horario";
                dgvHorario.Columns["Horario_dia"].HeaderText = "Dia";
                dgvHorario.Columns["Horario_horaInicial"].HeaderText = "Hora Inicial";
                dgvHorario.Columns["Horario_horaFinal"].HeaderText = "Hora Final";
                dgvHorario.Columns["Horario_estado"].Visible = false;
            }
        }

        private void CargarComboHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                cbxHorario.DataSource = elHorario.ListarHorario();

                cbxHorario.ValueMember = "Horario_id";
                cbxHorario.DisplayMember = "Horario_descripcion";
            }
        }

        private void BuscarHorario()
        {
            Horario_id = int.Parse(cbxHorario.SelectedValue.ToString());
            using (GestorHorario Horario = new GestorHorario())
            {
                this.dsHorario = Horario.ConsultarHorario(Horario_id);
                this.dtHorario = this.dsHorario.Tables[0];
            }
            CargarDatosHorario();
        }

        private void CargarDatosHorario()
        {
            txtHorario_descripcion.Text = this.dtHorario.Rows[0]["Horario_descripcion"].ToString();
            txtHorario_dia.Text = this.dtHorario.Rows[0]["Horario_dia"].ToString();
            txtHorario_horaInicio.Text = this.dtHorario.Rows[0]["Horario_horaInicial"].ToString();
            txtHorario_horaFinal.Text = this.dtHorario.Rows[0]["Horario_horaFinal"].ToString();
        }


        //--------------------------------------------------------------------



        private void dgvHorario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dgvHorario.CurrentCell.RowIndex;
                Horario_id = int.Parse(this.dgvHorario[0, numFila].Value.ToString());

                using (GestorHorario elHorario = new GestorHorario())
                {
                    this.dsHorario = elHorario.ConsultarHorario(Horario_id);
                    this.dtHorario = this.dsHorario.Tables[0];

                }
                CargarDatosHorario();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. ingrese datos", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarHorario();
        }

        private void btnHorario_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                elHorario.InsertarHorario(txtHorario_descripcion.Text, txtHorario_dia.Text, txtHorario_horaInicio.Text, txtHorario_horaFinal.Text, "A");
            }
            Horario_id = 0;
            CargarGridHorario();
            CargarComboHorario();
        }

        private void btnHorario_Modificar_Click(object sender, EventArgs e)
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                elHorario.ModificarHorario(Horario_id, txtHorario_descripcion.Text, txtHorario_dia.Text, txtHorario_horaInicio.Text, txtHorario_horaFinal.Text, "A");
            }

            CargarGridHorario();
            CargarComboHorario();
        }

        private void btnReporteProfesor_Click(object sender, EventArgs e)
        {
            FrmReporteHorario resporte = new FrmReporteHorario();
            resporte.Show();
        }
    }
}
