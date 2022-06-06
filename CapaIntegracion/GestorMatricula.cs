using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio;
using SistemaMatricula.CapaLogica.Servicios;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaIntegracion
{
    public class GestorMatricula:servicio, IDisposable
    {

        public GestorMatricula()
        {

        }

        public void Dispose()
        {

        } 

        public string InsertarMatricula(int Estudiante_id,int Grupo_id, int Curso_id, 
            int Porfesor__id, int Horario_id, int Aula_id, string Matricula_comprobante, 
            string Matricula_estado)
        {
            Matricula nuevaMatricula = new Matricula(Estudiante_id, Grupo_id, Curso_id,
            Porfesor__id, Horario_id, Aula_id, Matricula_comprobante,
            Matricula_estado);

            using (ServicioMatricula laMatricula= new ServicioMatricula())
                return laMatricula.InsertarMatricula(nuevaMatricula);
        }

        public object ListarMatricula()
        {
            using (ServicioMatricula laMatricula = new ServicioMatricula())
                return laMatricula.ListarMatricula();
        }

        public string ModificarMatricula(int Matricula_id,int Estudiante_id, int Grupo_id, int Curso_id,
            int Porfesor__id, int Horario_id, int Aula_id, string Matricula_comprobante,
            string Matricula_estado)
        {
            Matricula modificarMatricula = new Matricula(Matricula_id, Estudiante_id, Grupo_id, Curso_id,
            Porfesor__id, Horario_id, Aula_id, Matricula_comprobante,
            Matricula_estado);

            using (ServicioMatricula laMatricula = new ServicioMatricula())
                return laMatricula.ModificarMatricula(modificarMatricula);
        }

        public DataSet ConsultarMatricula(int Matricula_id)
        {
            using (ServicioMatricula laMatricula = new ServicioMatricula())
            {
                return laMatricula.consultarMatricual(Matricula_id);
            }
        }
    }
}
