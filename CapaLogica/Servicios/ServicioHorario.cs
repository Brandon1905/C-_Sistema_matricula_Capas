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
    public class ServicioHorario : servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioHorario()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarHorario(Horario elHorario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Horario");

            //InsertarProfesor igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "InsertarHorario";

            miComando.Parameters.Add("Horario_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Horario_descripcion"].Value = elHorario.Horario_descripcion;


            miComando.Parameters.Add("Horario_dia", SqlDbType.VarChar);
            miComando.Parameters["Horario_dia"].Value = elHorario.Horario_dia;

            miComando.Parameters.Add("Horario_horaInicial", SqlDbType.VarChar);
            miComando.Parameters["Horario_horaInicial"].Value = elHorario.Horario_horaInicial;

            miComando.Parameters.Add("Horario_horaFinal", SqlDbType.VarChar);
            miComando.Parameters["Horario_horaFinal"].Value = elHorario.Horario_horaFinal;

            miComando.Parameters.Add("Horario_estado", SqlDbType.VarChar);
            miComando.Parameters["Horario_estado"].Value = elHorario.Horario_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realisado carrectamente la transacción InsertarHorario";
            }
            Console.WriteLine("Fin Servicio InsertarHorario");

            return respuesta;
        }

        public string ModificarHorario(Horario elHorario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Horario");


            miComando.CommandText = "ModificarHorario";

            miComando.Parameters.Add("Horario_id", SqlDbType.Int);
            miComando.Parameters["Horario_id"].Value = elHorario.Horario_id;

            miComando.Parameters.Add("Horario_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Horario_descripcion"].Value = elHorario.Horario_descripcion;

            miComando.Parameters.Add("Horario_dia", SqlDbType.VarChar);
            miComando.Parameters["Horario_dia"].Value = elHorario.Horario_dia;

            miComando.Parameters.Add("Horario_horaInicial", SqlDbType.VarChar);
            miComando.Parameters["Horario_horaInicial"].Value = elHorario.Horario_horaInicial;

            miComando.Parameters.Add("Horario_horaFinal", SqlDbType.VarChar);
            miComando.Parameters["Horario_horaFinal"].Value = elHorario.Horario_horaFinal;

            miComando.Parameters.Add("Horario_estado", SqlDbType.VarChar);
            miComando.Parameters["Horario_estado"].Value = elHorario.Horario_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realisado carrectamente la transacción ModificarHorario";
            }
            Console.WriteLine("Fin Servicio ModificarHorario");

            return respuesta;
        }

        public DataSet ConsultarHorario(int Horario_id)
        {
            miComando.CommandText = "ConsultarHorario";
            miComando.Parameters.AddWithValue("@Horario_id", SqlDbType.Int);
            miComando.Parameters["@Horario_id"].Value = Horario_id;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.selecionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarHorario()
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gertor Listar Horario");

            miComando.CommandText = "ListarHorario";

            DataSet elHorario = new DataSet();
            this.abrirConexion();

            elHorario = this.selecionarInformacion(miComando);
            DataTable miTabla = elHorario.Tables[0];

            return miTabla;
        }

        public string InactivarHorario(int Horario_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor InactivarHorario.");

            miComando.CommandText = "InactivarHorario";

            miComando.Parameters.AddWithValue("@Horario_id", SqlDbType.Int);
            miComando.Parameters["@Horario_id"].Value = Horario_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                respuesta += "Se ha realiado correctamente la transaccion InactivarHorario";
                Console.WriteLine("Fin Gestor InactivarHorario");
            }

            return respuesta;
        }


    }
}
