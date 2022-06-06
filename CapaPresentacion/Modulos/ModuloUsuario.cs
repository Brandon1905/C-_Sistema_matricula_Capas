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
    public partial class ModuloUsuario : Form
    {
        DataSet dsUsuario = new DataSet();
        DataTable dtUsuario = new DataTable();
        private int Usuario_id = 0;

        public ModuloUsuario()
        {
            InitializeComponent();
        }

        private void ModuloUsuario_Load(object sender, EventArgs e)
        {
            CargarGridUsuario();
            CargarComboUsuario();
        }

        private void CargarGridUsuario()
        {
            using (GestorUsuario elUsuario = new GestorUsuario())
            {
                dgvUsuario.DataSource = elUsuario.ListarUsuario();

                dgvUsuario.Columns["TUsuario_id"].Visible = false;
                dgvUsuario.Columns["Usuario_nombre"].HeaderText = "Nombre";
                dgvUsuario.Columns["Usuario_contraseña"].HeaderText = "Contraseña";
                dgvUsuario.Columns["Usuario_estado"].Visible = false;
            }
        }

        private void CargarComboUsuario()
        {
            using (GestorUsuario elUsuario = new GestorUsuario())
            {
                cbxUsuario.DataSource = elUsuario.ListarUsuario();
                   
                cbxUsuario.ValueMember = "TUsuario_id";
                cbxUsuario.DisplayMember = "Usuario_nombre";
            }
        }

        private void BuscarUsuario()
        {
            Usuario_id = int.Parse(cbxUsuario.SelectedValue.ToString());
            using (GestorUsuario Usuario = new GestorUsuario())
            {
                this.dsUsuario = Usuario.ConsultarUsuario(Usuario_id);
                this.dtUsuario = this.dsUsuario.Tables[0];
            }
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            txtUsuario_nombre.Text = this.dtUsuario.Rows[0]["Usuario_nombre"].ToString();
            txtUsuario_Contraseña.Text = this.dtUsuario.Rows[0]["Usuario_contraseña"].ToString();
        }


        //--------------------------------------------------------------------


        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dgvUsuario.CurrentCell.RowIndex;
                Usuario_id = int.Parse(this.dgvUsuario[0, numFila].Value.ToString());

                using (GestorUsuario elUsuario = new GestorUsuario())
                {
                    this.dsUsuario = elUsuario.ConsultarUsuario(Usuario_id);
                    this.dtUsuario = this.dsUsuario.Tables[0];

                }
                CargarDatosUsuario();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacía. ingrese datos", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void btnUsuario_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorUsuario elUsuario = new GestorUsuario())
            {
                elUsuario.InsertarUsuario(txtUsuario_nombre.Text, txtUsuario_Contraseña.Text, "A");
            }
            Usuario_id = 0;
            CargarGridUsuario();
            CargarComboUsuario();
        }

        private void btnUsuario_Modificar_Click(object sender, EventArgs e)
        {
            using (GestorUsuario elUsuario = new GestorUsuario())
            {
                elUsuario.ModificarUsuario(Usuario_id, txtUsuario_nombre.Text, txtUsuario_Contraseña.Text, "A");
            }

            CargarGridUsuario();
            CargarComboUsuario();
        }

        private void btnReporteUsuario_Click(object sender, EventArgs e)
        {
            FrmReporteUsuario resporte = new FrmReporteUsuario();
            resporte.Show();
        }
    }
}
