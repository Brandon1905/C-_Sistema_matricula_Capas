using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio;

namespace CapaLogica.Servicios
{
    public class ServicioGrupo:servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioGrupo()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarGrupo(Grupo elgrupo)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Grupo");

            //InsertarProfesor igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "InsertarGrupo";

            miComando.Parameters.Add("Grupo_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Grupo_descripcion"].Value = elgrupo.Grupo_descripcion;

            miComando.Parameters.Add("Grupo_estado", SqlDbType.VarChar);
            miComando.Parameters["Grupo_estado"].Value = elgrupo.Grupo_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realisado carrectamente la transacción InsertarGrupo";
            }
            Console.WriteLine("Fin Servicio InsertarGrupo");

            return respuesta;
        }

        public string ModificarGrupo(Grupo elgrupo)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Grupo");

            miComando.CommandText = "ModificarGrupo";

            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = elgrupo.Grupo_id;

            miComando.Parameters.Add("Grupo_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Grupo_descripcion"].Value = elgrupo.Grupo_descripcion;

            miComando.Parameters.Add("Grupo_estado", SqlDbType.VarChar);
            miComando.Parameters["Grupo_estado"].Value = elgrupo.Grupo_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realisado carrectamente la transacción ModificarGrupo";
            }
            Console.WriteLine("Fin Servicio ModificarGrupo");

            return respuesta;
        }

        public DataSet ConsultarGrupo(int Grupo_id)
        {
            miComando.CommandText = "ConsultarGrupo";
            miComando.Parameters.AddWithValue("@Grupo_id", SqlDbType.Int);
            miComando.Parameters["@Grupo_id"].Value = Grupo_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.selecionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarGrupo()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gertor Listar Grupo");

            miComando.CommandText = "ListarGrupo";

            DataSet elGrupo = new DataSet();
            this.abrirConexion();

            elGrupo = this.selecionarInformacion(miComando);
            DataTable miTabla = elGrupo.Tables[0];

            return miTabla;
        }

        public string InactivarGrupo(int Grupo_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InactivarGrupo.");

            miComando.CommandText = "InactivarGrupo";

            miComando.Parameters.AddWithValue("@Grupo_id", SqlDbType.Int);
            miComando.Parameters["@Grupo_id"].Value = Grupo_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realiado correctamente la transaccion InactivarGrupo";
                Console.WriteLine("Fin Gestor InactivarGrupo");
            }

            return respuesta;
        }
    }
}
