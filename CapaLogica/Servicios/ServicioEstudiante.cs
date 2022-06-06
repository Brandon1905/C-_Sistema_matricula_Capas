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
    public class ServicioEstudiante : servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }

        public ServicioEstudiante()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarEstudiante(Estudiante elEstudiante)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InsertarEstudianter");

            miComando.CommandText = "InsertarEstudiante";

            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = elEstudiante.Grupo_id;

            miComando.Parameters.Add("Estudiante_cedula", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_cedula"].Value = elEstudiante.Estudiante_cedula;

            miComando.Parameters.Add("Estudiante_nombre", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_nombre"].Value = elEstudiante.Estudiante_nombre;

            miComando.Parameters.Add("Estudiante_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_primerApellido"].Value = elEstudiante.Estudiante_primerApellido;

            miComando.Parameters.Add("Estudiante_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_segundoApellido"].Value = elEstudiante.Estudiante_segundoApellido;

            miComando.Parameters.Add("Estudiante_telefono", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_telefono"].Value = elEstudiante.Estudiante_telefono;

            miComando.Parameters.Add("Estudiante_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_correoElectronico"].Value = elEstudiante.Estudiante_correoElectronico;

            miComando.Parameters.Add("Estudiante_direccion", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_direccion"].Value = elEstudiante.Estudiante_direccion;

            miComando.Parameters.Add("Estudiante_estado", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_estado"].Value = elEstudiante.Estudiante_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se a realizado la transacción Insertar Estudiante";

            Console.WriteLine("Fin servicio Insertar Estudiante");

            return respuesta;
        }

        public string ModificarEstudianter(Estudiante elEstudiante)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor ModificarEstudiante");

            miComando.CommandText = "ModificarEstudiante";

            miComando.Parameters.Add("Estudiante_id", SqlDbType.Int);
            miComando.Parameters["Estudiante_id"].Value = elEstudiante.Estudiante_id;

            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = elEstudiante.Grupo_id;

            miComando.Parameters.Add("Estudiante_cedula", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_cedula"].Value = elEstudiante.Estudiante_cedula;

            miComando.Parameters.Add("Estudiante_nombre", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_nombre"].Value = elEstudiante.Estudiante_nombre;

            miComando.Parameters.Add("Estudiante_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_primerApellido"].Value = elEstudiante.Estudiante_primerApellido;

            miComando.Parameters.Add("Estudiante_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_segundoApellido"].Value = elEstudiante.Estudiante_segundoApellido;

            miComando.Parameters.Add("Estudiante_telefono", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_telefono"].Value = elEstudiante.Estudiante_telefono;

            miComando.Parameters.Add("Estudiante_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_correoElectronico"].Value = elEstudiante.Estudiante_correoElectronico;

            miComando.Parameters.Add("Estudiante_direccion", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_direccion"].Value = elEstudiante.Estudiante_direccion;

            miComando.Parameters.Add("Estudiante_estado", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_estado"].Value = elEstudiante.Estudiante_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se a realizado la transacción Modificar Estudiante";

            Console.WriteLine("Fin servicio ModificarEstudiante");

            return respuesta;
        }

        public DataSet consultarEstudiante(int Estudiante_id)
        {
            miComando.CommandText = "ConsultarEstudiante";
            miComando.Parameters.AddWithValue("@Estudiante_id", SqlDbType.Int);
            miComando.Parameters["@Estudiante_id"].Value = Estudiante_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.selecionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarEstudiante()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Estudiante");

            miComando.CommandText = "ListarEstudiantes";

            DataSet elEstudiante = new DataSet();
            this.abrirConexion();

            elEstudiante = this.selecionarInformacion(miComando);
            DataTable miTabla = elEstudiante.Tables[0];

            return miTabla;

        }

        public string InactivarEstudiante(int Estudiante_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InactivarEstudiante.");

            miComando.CommandText = "InactivarEstudiante";

            miComando.Parameters.AddWithValue("@Estudiante_id", SqlDbType.Int);
            miComando.Parameters["@Estudiante_id"].Value = Estudiante_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realiado correctamente la transaccion InactivarEstudiante";
                Console.WriteLine("Fin Gestor InactivarEstudiante");
            }

            return respuesta;
        }
    }
}
