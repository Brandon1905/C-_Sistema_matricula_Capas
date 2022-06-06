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
    public class ServicioUsuario : servicio, IDisposable
    {
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose()
        {

        }

        public ServicioUsuario()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarUsuario(Usuario elUsuario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Usuario");

            //InsertarProfesor igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "InsertarUsuario";

            miComando.Parameters.Add("Usuario_nombre", SqlDbType.VarChar);
            miComando.Parameters["Usuario_nombre"].Value = elUsuario.Usuario_nombre;


            miComando.Parameters.Add("Usuario_contraseña", SqlDbType.VarChar);
            miComando.Parameters["Usuario_contraseña"].Value = elUsuario.Usuario_contraseña;

            miComando.Parameters.Add("Usuario_estado", SqlDbType.VarChar);
            miComando.Parameters["Usuario_estado"].Value = elUsuario.Usuario_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realisado carrectamente la transacción InsertarUsuario";
            }
            Console.WriteLine("Fin Servicio InsertarUsuario");

            return respuesta;
        }

        public string ModificarUsuario(Usuario elUsuario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Usuario");


            miComando.CommandText = "ModificarUsuario";

            miComando.Parameters.Add("TUsuario_id", SqlDbType.Int);
            miComando.Parameters["TUsuario_id"].Value = elUsuario.TUsuario_id;

            miComando.Parameters.Add("Usuario_nombre", SqlDbType.VarChar);
            miComando.Parameters["Usuario_nombre"].Value = elUsuario.Usuario_nombre;

            miComando.Parameters.Add("Usuario_contraseña", SqlDbType.VarChar);
            miComando.Parameters["Usuario_contraseña"].Value = elUsuario.Usuario_contraseña;

            miComando.Parameters.Add("Usuario_estado", SqlDbType.VarChar);
            miComando.Parameters["Usuario_estado"].Value = elUsuario.Usuario_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realisado carrectamente la transacción ModificarUsuario";
            }
            Console.WriteLine("Fin Servicio ModificarUsuario");

            return respuesta;
        }

        public DataSet ConsultarUsuario(int TUsuario_id)
        {
            miComando.CommandText = "ConsultarUsuario";
            miComando.Parameters.AddWithValue("@TUsuario_id", SqlDbType.Int);
            miComando.Parameters["@TUsuario_id"].Value = TUsuario_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.selecionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarUsuario()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gertor Listar Usuario");

            miComando.CommandText = "ListarUsuario";

            DataSet elUsuario = new DataSet();
            this.abrirConexion();

            elUsuario = this.selecionarInformacion(miComando);
            DataTable miTabla = elUsuario.Tables[0];

            return miTabla;
        }

        public string InactivarUsuario(int TUsuario_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Usuario.");

            miComando.CommandText = "InactivarUsuario";

            miComando.Parameters.AddWithValue("@TUsuario_id", SqlDbType.Int);
            miComando.Parameters["@TUsuario_id"].Value = TUsuario_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realiado correctamente la transaccion Inactivar Usuario";
                Console.WriteLine("Fin Gestor InactivarUsuario");
            }

            return respuesta;
        }















    }
}
