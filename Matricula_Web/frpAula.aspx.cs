using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaIntegracion;

namespace Matricula_Web
{
    public partial class frpAula : System.Web.UI.Page
    {
        DataSet dsAula;
        DataTable dtAula;
        private int Aula_id = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarComboAula();
            CargarGridAula();

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.InsertarAula(txtAula_descripcion.Text, txtAula_capacidad.Text, "A");
            }
            Aula_id = 0;
            CargarGridAula();
            CargarComboAula();
        }

        private void CargarGridAula()
        {
            if (!IsPostBack)
            {
                using (GestorAula elAula = new GestorAula())
                {
                    gvAula.DataSource = elAula.ListarAula();
                    gvAula.DataBind();
                }
            }
        }

        private void CargarComboAula()
        {
            if (!IsPostBack) { 

                using (GestorAula elAula = new GestorAula())
                {
                    ddlAula.DataSource = elAula.ListarAula();

                    ddlAula.DataValueField = "Aula_id";
                    ddlAula.DataTextField = "Aula_descripcion";

                    ddlAula.DataBind();
                    ddlAula.SelectedIndex = 0;
                }
            }
        }

        protected void btnCargarDatos_Click(object sender, EventArgs e)
        {
            Aula_id = int.Parse(ddlAula.SelectedValue.ToString());

            using (GestorAula Profesor = new GestorAula())
            {
                this.dsAula = Profesor.ConsultarAula(Aula_id);
                this.dtAula = this.dsAula.Tables[0];
            }
            CargarDatosAula();
        }

        private void CargarDatosAula()
        {
            txtAula_descripcion.Text = this.dtAula.Rows[0]["Aula_descripcion"].ToString();
            txtAula_capacidad.Text = this.dtAula.Rows[0]["Aula_capacidad"].ToString();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.ModificarAula(Aula_id, txtAula_descripcion.Text, txtAula_capacidad.Text, "A");
            }

            CargarGridAula();
            CargarComboAula();
        }
    }
}