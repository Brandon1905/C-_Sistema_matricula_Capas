using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatricula.CapaLogica.LogicaNegocio;
using SistemaMatricula.CapaLogica.Servicios;
using SistemaMatricula.CapaConexion;
using System.Data;
using CapaLogica.Servicios;

namespace CapaIntegracion
{
    public class GestorAula : servicio, IDisposable
    {
        public GestorAula()
        {

        }

        public void Dispose()
        {

        }

        public string InsertarAula(string Aula_descripcion, string Aula_capacidad, string Aula_estado)
        {
            Aula nuevoAula = new Aula(Aula_descripcion, Aula_capacidad, Aula_estado);

            using (ServicioAula elAula = new ServicioAula())
                return elAula.InsertarAula(nuevoAula);

        }

        public object ListarAula()
        {
            using (ServicioAula elAula = new ServicioAula())
                return elAula.ListarAula();
        }

        public string ModificarAula(int Aula_id, string Aula_descripcion, string Aula_capacidad, string Aula_estado)
        {
            Aula modificarAula = new Aula(Aula_id, Aula_descripcion, Aula_capacidad, Aula_estado);

            using (ServicioAula elAula = new ServicioAula())
                return elAula.ModificarAula(modificarAula);
        }

        public DataSet ConsultarAula(int Aula_id)
        {
            using (ServicioAula elAula = new ServicioAula())
            {
                return elAula.ConsultarAula(Aula_id);
            }
        }
    }
}
