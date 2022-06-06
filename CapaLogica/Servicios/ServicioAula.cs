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
    public class ServicioAula:servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioAula()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarAula(Aula elaula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Aula");

            //InsertarProfesor igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "InsertarAula";

            miComando.Parameters.Add("Aula_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Aula_descripcion"].Value = elaula.Aula_descripcion;

            miComando.Parameters.Add("Aula_capacidad", SqlDbType.VarChar);
            miComando.Parameters["Aula_capacidad"].Value = elaula.Aula_capacidad;

            miComando.Parameters.Add("Aula_estado", SqlDbType.VarChar);
            miComando.Parameters["Aula_estado"].Value = elaula.Aula_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realisado carrectamente la transacción InsertarAula";
            }
            Console.WriteLine("Fin Servicio InsertarAula");

            return respuesta;
        }

        public string ModificarAula(Aula elAula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Aula");


            miComando.CommandText = "ModificarAula";

            miComando.Parameters.Add("Aula_id", SqlDbType.Int);
            miComando.Parameters["Aula_id"].Value = elAula.Aula_id;
          
            miComando.Parameters.Add("Aula_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Aula_descripcion"].Value = elAula.Aula_descripcion;

            miComando.Parameters.Add("Aula_capacidad", SqlDbType.VarChar);
            miComando.Parameters["Aula_capacidad"].Value = elAula.Aula_capacidad;

            miComando.Parameters.Add("Aula_estado", SqlDbType.VarChar);
            miComando.Parameters["Aula_estado"].Value = elAula.Aula_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realisado carrectamente la transacción ModificarAula";
            }
            Console.WriteLine("Fin Servicio ModificarAula");

            return respuesta;
        }

        public DataSet ConsultarAula(int Aula_id)
        {
            miComando.CommandText = "ConsultarAula";
            miComando.Parameters.AddWithValue("@Aula_id", SqlDbType.Int);
            miComando.Parameters["@Aula_id"].Value = Aula_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.selecionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarAula()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gertor Listar Aula");

            miComando.CommandText = "ListarAula";

            DataSet elAula = new DataSet();
            this.abrirConexion();

            elAula = this.selecionarInformacion(miComando);
            DataTable miTabla = elAula.Tables[0];

            return miTabla;
        }

        public string InactivarAula(int Aula_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InactivarAula.");

            miComando.CommandText = "InactivarAula";

            miComando.Parameters.AddWithValue("@Aula_id", SqlDbType.Int);
            miComando.Parameters["@Aula_id"].Value = Aula_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realiado correctamente la transaccion InactivarAula";
                Console.WriteLine("Fin Gestor InactivarAula");
            }

            return respuesta;
        }
    }
}
