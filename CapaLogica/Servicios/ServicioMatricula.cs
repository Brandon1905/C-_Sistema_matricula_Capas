using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio;
using System.Data;
using System.Data.SqlClient;

namespace SistemaMatricula.CapaLogica.Servicios
{
    public class ServicioMatricula : servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }
        public ServicioMatricula()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarMatricula(Matricula laMatricula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InsertarMatricula");

            miComando.CommandText = "InsertarMatricula";

            miComando.Parameters.Add("Estudiante_id", SqlDbType.Int);
            miComando.Parameters["Estudiante_id"].Value = laMatricula.Estudiante_id;

            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = laMatricula.Grupo_id;

            miComando.Parameters.Add("Curso_id", SqlDbType.Int);
            miComando.Parameters["Curso_id"].Value = laMatricula.Curso_id;

            miComando.Parameters.Add("Profesor_id", SqlDbType.Int);
            miComando.Parameters["Profesor_id"].Value = laMatricula.Profesor_id;

            miComando.Parameters.Add("Horario_id", SqlDbType.Int);
            miComando.Parameters["Horario_id"].Value = laMatricula.Horario_id;

            miComando.Parameters.Add("Aula_id", SqlDbType.Int);
            miComando.Parameters["Aula_id"].Value = laMatricula.Aula_id;

            miComando.Parameters.Add("Matricula_comprobante", SqlDbType.VarChar);
            miComando.Parameters["Matricula_comprobante"].Value = laMatricula.Matricula_comprobante;

            miComando.Parameters.Add("Matricula_estado", SqlDbType.VarChar);
            miComando.Parameters["Matricula_estado"].Value = laMatricula.Matricula_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se a realizado la transacción InsertarMatricula";

            Console.WriteLine("Fin servicio InsertarMatricula");

            return respuesta;
        }
        public string ModificarMatricula(Matricula laMatricula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ModificarMatricula");

            miComando.CommandText = "ModificarMatricula";

            miComando.Parameters.Add("Matricula_id", SqlDbType.Int);
            miComando.Parameters["Matricula_id"].Value = laMatricula.Matricula_id;

            miComando.Parameters.Add("Estudiante_id", SqlDbType.Int);
            miComando.Parameters["Estudiante_id"].Value = laMatricula.Estudiante_id;

            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = laMatricula.Grupo_id;

            miComando.Parameters.Add("Curso_id", SqlDbType.Int);
            miComando.Parameters["Curso_id"].Value = laMatricula.Curso_id;

            miComando.Parameters.Add("Profesor_id", SqlDbType.Int);
            miComando.Parameters["Profesor_id"].Value = laMatricula.Profesor_id;

            miComando.Parameters.Add("Horario_id", SqlDbType.Int);
            miComando.Parameters["Horario_id"].Value = laMatricula.Horario_id;

            miComando.Parameters.Add("Aula_id", SqlDbType.Int);
            miComando.Parameters["Aula_id"].Value = laMatricula.Aula_id;

            miComando.Parameters.Add("Matricula_comprobante", SqlDbType.VarChar);
            miComando.Parameters["Matricula_comprobante"].Value = laMatricula.Matricula_comprobante;

            miComando.Parameters.Add("Matricula_estado", SqlDbType.VarChar);
            miComando.Parameters["Matricula_estado"].Value = laMatricula.Matricula_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se a realizado la transacción ModificarMatricula";

            Console.WriteLine("Fin servicio ModificarMatricula");

            return respuesta;
        }
        public DataSet consultarMatricual(int Matricula_id)
        {
            miComando.CommandText = "ConsultarMatricula";
            miComando.Parameters.AddWithValue("@Matricula_id", SqlDbType.Int);
            miComando.Parameters["@Matricula_id"].Value = Matricula_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.selecionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }
        public DataTable ListarMatricula()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Matricula");

            miComando.CommandText = "ListarMatriculaS";

            DataSet elMatricular = new DataSet();
            this.abrirConexion();

            elMatricular = this.selecionarInformacion(miComando);
            DataTable miTabla = elMatricular.Tables[0];

            return miTabla;
        }


        public string InactivarMatricula(int Matricula_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Matricula.");

            miComando.CommandText = "InactivarMatricula";

            miComando.Parameters.AddWithValue("@Matricula_id", SqlDbType.Int);
            miComando.Parameters["@Matricula_id"].Value = Matricula_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realiado correctamente la transaccion Inactivar Matricula";
                Console.WriteLine("Fin Gestor InactivarMatricula");
            }

            return respuesta;
        }
    }
}
