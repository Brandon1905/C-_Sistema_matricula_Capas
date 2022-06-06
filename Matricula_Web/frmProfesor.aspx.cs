using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaMatricula.CapaIntegracion;

namespace Matricula_Web
{
    public partial class frmProfesor : System.Web.UI.Page
    {
        DataSet dsProfesor;
        DataTable dtProfesor;
        private int profesor_id = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarComboProfesor();
            CargarGridProfesor();
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elprofesor = new GestorProfesor())
            {
                elprofesor.InsertarProfesor(txtProfesor_cedula.Text, txtProfesor_nombre.Text, txtProfesor_primerApellido.Text,
                    txtProfesor_segundoApellido.Text, txtProfesor_telefono.Text, txtProfesor_correoElectronico.Text,
                    txtProfesor_direccion.Text, "A");
            }
            profesor_id = 0;

            CargarGridProfesor();
            CargarComboProfesor();
        }

        private void CargarComboProfesor()
        {
            if (!IsPostBack)
            {
                using (GestorProfesor elProfesor = new GestorProfesor())
                {
                    ddlProfesor.DataSource = elProfesor.ListarProfesor();

                    ddlProfesor.DataValueField = "Profesor_id";
                    ddlProfesor.DataTextField = "Profesor_cedula";

                    ddlProfesor.DataBind();
                    ddlProfesor.SelectedIndex = 0;
                }
            }
        }

        private void CargarGridProfesor()
        {
            if (!IsPostBack)
            {
                using (GestorProfesor elProfesor = new GestorProfesor())
                {
                    gvProfesor.DataSource = elProfesor.ListarProfesor();
                    gvProfesor.DataBind();
                }
            }
        }

        protected void btnCargarDatos_Click(object sender, EventArgs e)
        {
             profesor_id = int.Parse(ddlProfesor.SelectedValue.ToString());

             using (GestorProfesor Profesor = new GestorProfesor())
             {
                this.dsProfesor = Profesor.ConsultarProfesor(profesor_id);
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

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                elProfesor.ModificarProfesor(profesor_id, txtProfesor_cedula.Text, txtProfesor_nombre.Text, txtProfesor_primerApellido.Text, txtProfesor_segundoApellido.Text,
                                            txtProfesor_telefono.Text, txtProfesor_correoElectronico.Text, txtProfesor_direccion.Text, "A");
            }

            CargarGridProfesor();
            CargarComboProfesor();

            //Response.Redirect("frpAula.aspx");
        }

        protected void gvProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}