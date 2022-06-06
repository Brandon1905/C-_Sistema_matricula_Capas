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
    public class ServicioProfesor:servicio, IDisposable 
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }

        public ServicioProfesor()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarProfesor(Profesor elProfesor)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor insertar profesor.");

            miComando.CommandText = "InsertarProfesor";

            miComando.Parameters.Add("Profesor_cedula", SqlDbType.VarChar);
            miComando.Parameters["Profesor_cedula"].Value = elProfesor.Profesor_cedula;

            miComando.Parameters.Add("Profesor_nombre", SqlDbType.VarChar);
            miComando.Parameters["Profesor_nombre"].Value = elProfesor.Profesor_nombre;

            miComando.Parameters.Add("Profesor_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["Profesor_primerApellido"].Value = elProfesor.Profesor_primerApellido;

            miComando.Parameters.Add("Profesor_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["Profesor_segundoApellido"].Value = elProfesor.Profesor_segundoApellido;

            miComando.Parameters.Add("Profesor_telefono", SqlDbType.VarChar);
            miComando.Parameters["Profesor_telefono"].Value = elProfesor.Profesor_telefono;

            miComando.Parameters.Add("Profesor_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Profesor_correoElectronico"].Value = elProfesor.Profesor_correoElectronico;

            miComando.Parameters.Add("Profesor_direccion", SqlDbType.VarChar);
            miComando.Parameters["Profesor_direccion"].Value = elProfesor.Profesor_direccion;

            miComando.Parameters.Add("Profesor_estado", SqlDbType.VarChar);
            miComando.Parameters["Profesor_estado"].Value = elProfesor.Profesor_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if(respuesta == "")
            {
                respuesta += "Se ha realiado correctamente la transaccion Insertar Profesor";
                Console.WriteLine("Fin Gestor Insertar Profesor");
            }

            return respuesta;
        }

        public string ModificarProfesor(Profesor elProfesor)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar profesor.");

            miComando.CommandText = "ModificarProfesor";

            miComando.Parameters.Add("Profesor_id", SqlDbType.VarChar);
            miComando.Parameters["Profesor_id"].Value = elProfesor.Profesor_id;

            miComando.Parameters.Add("Profesor_cedula", SqlDbType.VarChar);
            miComando.Parameters["Profesor_cedula"].Value = elProfesor.Profesor_cedula;

            miComando.Parameters.Add("Profesor_nombre", SqlDbType.VarChar);
            miComando.Parameters["Profesor_nombre"].Value = elProfesor.Profesor_nombre;

            miComando.Parameters.Add("Profesor_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["Profesor_primerApellido"].Value = elProfesor.Profesor_primerApellido;

            miComando.Parameters.Add("Profesor_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["Profesor_segundoApellido"].Value = elProfesor.Profesor_segundoApellido;

            miComando.Parameters.Add("Profesor_telefono", SqlDbType.VarChar);
            miComando.Parameters["Profesor_telefono"].Value = elProfesor.Profesor_telefono;

            miComando.Parameters.Add("Profesor_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Profesor_correoElectronico"].Value = elProfesor.Profesor_correoElectronico;

            miComando.Parameters.Add("Profesor_direccion", SqlDbType.VarChar);
            miComando.Parameters["Profesor_direccion"].Value = elProfesor.Profesor_direccion;

            miComando.Parameters.Add("Profesor_estado", SqlDbType.VarChar);
            miComando.Parameters["Profesor_estado"].Value = elProfesor.Profesor_estado;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                respuesta += "Se ha realiado correctamente la transaccion Modificar Profesor";
                Console.WriteLine("Fin Gestor ModificarProfesor");
            }
                       return respuesta;
        }

        public DataSet ConsultarProfesor(int Profesor_id)
        {
            miComando.CommandText = "Consultarprofesor";
            miComando.Parameters.AddWithValue("@Profesor_id", SqlDbType.Int);
            miComando.Parameters["@Profesor_id"].Value = Profesor_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.selecionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarProfesor()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gertor Listar Profesor");

            miComando.CommandText = "ListarProfesor";

            DataSet elProfesor = new DataSet();
            this.abrirConexion();

            elProfesor = this.selecionarInformacion(miComando);
            DataTable miTabla = elProfesor.Tables[0];

            return miTabla;
        }

        public string InactivarProfesor(int Profesor_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Profesor.");

            miComando.CommandText = "InactivarProfesor";

            miComando.Parameters.AddWithValue("@Profesor_id", SqlDbType.Int);
            miComando.Parameters["@Profesor_id"].Value = Profesor_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realiado correctamente la transaccion Inactivar Profesor";
                Console.WriteLine("Fin Gestor InactivarProfesor");
            }

            return respuesta;
        }
    }
}
