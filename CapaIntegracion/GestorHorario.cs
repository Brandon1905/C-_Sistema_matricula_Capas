using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio;
using SistemaMatricula.CapaLogica.Servicios;

namespace CapaIntegracion
{
    public class GestorHorario : servicio, IDisposable
    {
        public GestorHorario()
        {

        }

        public void Dispose()
        {

        }

        public string InsertarHorario(string Horario_descripcion, string Horario_dia, string Horario_horaInicial, string Horario_horaFinal, string Horario_estado)
        {
            Horario nuevoHorario = new Horario(Horario_descripcion, Horario_dia, Horario_horaInicial, Horario_horaFinal, Horario_estado);

            using (ServicioHorario elHorario = new ServicioHorario())
            {
                return elHorario.InsertarHorario(nuevoHorario);
            }
        }

        public object ListarHorario()
        {
            using (ServicioHorario elHorario = new ServicioHorario())
                return elHorario.ListarHorario();
        }

        public string ModificarHorario(int Horario_id, string Horario_descripcion, string Horario_dia, string Horario_horaInicial, string Horario_horaFinal, string Horario_estado)
        {
            Horario modificarHorario = new Horario(Horario_id, Horario_descripcion, Horario_dia, Horario_horaInicial, Horario_horaFinal, Horario_estado);

            using (ServicioHorario elHorario = new ServicioHorario())
                return elHorario.ModificarHorario(modificarHorario);
        }

        public DataSet ConsultarHorario(int Horario_id)
        {
            using (ServicioHorario elHorario = new ServicioHorario())
            {
                return elHorario.ConsultarHorario(Horario_id);
            }
        }


















    }
}
