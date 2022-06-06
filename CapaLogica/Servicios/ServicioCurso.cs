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

namespace SistemaMatricula.CapaLogica.Servicios
{
    public class ServicioCurso:servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioCurso()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarCurso(Curso elCurso)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Curso");

            //InsertarProfesor igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "InsertarCurso";

            miComando.Parameters.Add("Curso_nombre", SqlDbType.VarChar);
            miComando.Parameters["Curso_nombre"].Value = elCurso.Curso_nombre;


            miComando.Parameters.Add("Curso_creditos", SqlDbType.VarChar);
            miComando.Parameters["Curso_creditos"].Value = elCurso.Curso_creditos;

            miComando.Parameters.Add("Curso_cupo", SqlDbType.VarChar);
            miComando.Parameters["Curso_cupo"].Value = elCurso.Curso_cupo;

            miComando.Parameters.Add("Curso_estado", SqlDbType.VarChar);
            miComando.Parameters["Curso_estado"].Value = elCurso.Curso_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realisado carrectamente la transacción InsertarCurso";
            }
            Console.WriteLine("Fin Servicio InsertarCurso");

            return respuesta;
        }

        public string ModificarAula(Curso elCurso)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Curso");


            miComando.CommandText = "ModificarCurso";

            miComando.Parameters.Add("Curso_id", SqlDbType.Int);
            miComando.Parameters["Curso_id"].Value = elCurso.Curso_id;

            miComando.Parameters.Add("Curso_nombre", SqlDbType.VarChar);
            miComando.Parameters["Curso_nombre"].Value = elCurso.Curso_nombre;

            miComando.Parameters.Add("Curso_creditos", SqlDbType.VarChar);
            miComando.Parameters["Curso_creditos"].Value = elCurso.Curso_creditos;

            miComando.Parameters.Add("Curso_cupo", SqlDbType.VarChar);
            miComando.Parameters["Curso_cupo"].Value = elCurso.Curso_cupo;

            miComando.Parameters.Add("Curso_estado", SqlDbType.VarChar);
            miComando.Parameters["Curso_estado"].Value = elCurso.Curso_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realisado carrectamente la transacción ModificarCurso";
            }
            Console.WriteLine("Fin Servicio ModificarCurso");

            return respuesta;
        }

        public DataSet ConsultarCurso(int Curso_id)
        {
            miComando.CommandText = "ConsultarCurso";
            miComando.Parameters.AddWithValue("@Curso_id", SqlDbType.Int);
            miComando.Parameters["@Curso_id"].Value = Curso_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.selecionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarCurso()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gertor Listar Curso");

            miComando.CommandText = "ListarCurso";

            DataSet elCurso = new DataSet();
            this.abrirConexion();

            elCurso = this.selecionarInformacion(miComando);
            DataTable miTabla = elCurso.Tables[0];

            return miTabla;
        }

        public string InactivarCurso(int Curso_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InactivarCurso.");

            miComando.CommandText = "InactivarCurso";

            miComando.Parameters.AddWithValue("@Curso_id", SqlDbType.Int);
            miComando.Parameters["@Curso_id"].Value = Curso_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realiado correctamente la transaccion InactivarCurso";
                Console.WriteLine("Fin Gestor InactivarCurso");
            }

            return respuesta;
        }
    }
}
