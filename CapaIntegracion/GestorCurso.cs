using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMatricula.CapaLogica.LogicaNegocio;
using SistemaMatricula.CapaLogica.Servicios;
using SistemaMatricula.CapaConexion;
using CapaLogica.Servicios;
using System.Data;

namespace CapaIntegracion
{
    public class GestorCurso : servicio, IDisposable
    {
        public GestorCurso()
        {

        }

        public void Dispose()
        {

        }

        public string InsertarCurso(string Curso_nombre, string Curso_creditos, string Curso_cupo, string Curso_estado)
        {
            Curso nuevoCurso = new Curso(Curso_nombre, Curso_creditos, Curso_cupo, Curso_estado);

            using (ServicioCurso elCurso = new ServicioCurso())
            {
                return elCurso.InsertarCurso(nuevoCurso);
            }
        }

        public object ListarCurso()
        {
            using (ServicioCurso elCurso = new ServicioCurso())
                return elCurso.ListarCurso();
        }

        public string ModificarCurso(int Curso_id, string Curso_nombre, string Curso_creditos, string Curso_cupo, string Curso_estado)
        {
            Curso modificarCurso = new Curso(Curso_id, Curso_nombre, Curso_creditos, Curso_cupo, Curso_estado);

            using (ServicioCurso elCurso = new ServicioCurso())
                return elCurso.ModificarAula(modificarCurso);

        }

        public DataSet ConsultarCurso(int Curso_id)
        {
            using (ServicioCurso elCurso = new ServicioCurso())
            {
                return elCurso.ConsultarCurso(Curso_id);
            }
        }
    }
}