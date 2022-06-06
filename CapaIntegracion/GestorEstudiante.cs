using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio;
using SistemaMatricula.CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorEstudiante:servicio, IDisposable
    {
        public GestorEstudiante()
        {

        }
        public void Dispose()
        {

        }

        public string InsertarEstudiante(int Grupo_id, string Estudiante_cedula, string Estudiante_nombre, string Estudiante_primerApellido,
            string Estudiante_segundoApellido, string Estudiante_telefono, string Estudiante_correoElectronico,
            string Estudiante_direccion, string Estudiante_estado)
        {
            Estudiante nuevoEstudiante = new Estudiante(Grupo_id, Estudiante_cedula, Estudiante_nombre, Estudiante_primerApellido,
                                                    Estudiante_segundoApellido, Estudiante_telefono, Estudiante_correoElectronico,
                                                    Estudiante_direccion, Estudiante_estado);

            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
                return elEstudiante.InsertarEstudiante(nuevoEstudiante);
        }

        public object ListarEstudiante()
        {
            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
                return elEstudiante.ListarEstudiante();
        }

        public string ModificarEstudiante(int Estudiante_id, int Grupo_id, string Estudiante_cedula, string Estudiante_nombre, string Estudiante_primerApellido,
            string Estudiante_segundoApellido, string Estudiante_telefono, string Estudiante_correoElectronico,
            string Estudiante_direccion, string Estudiante_estado)
        {
            Estudiante nuevoEstudiante = new Estudiante(Estudiante_id, Grupo_id, Estudiante_cedula, Estudiante_nombre, Estudiante_primerApellido,
                                                    Estudiante_segundoApellido, Estudiante_telefono, Estudiante_correoElectronico,
                                                    Estudiante_direccion, Estudiante_estado);

            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
                return elEstudiante.ModificarEstudianter(nuevoEstudiante);
        }

        public DataSet ConsultarEstudiante(int Estudiante_id)
        {
            using (ServicioEstudiante elEstudiante = new ServicioEstudiante())
            {
                return elEstudiante.consultarEstudiante(Estudiante_id);
            }
        }






    }
}
