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

namespace SistemaMatricula.CapaIntegracion
{
    public class GestorProfesor : servicio, IDisposable
    {
        public GestorProfesor()
        {

        }

        public void Dispose()
        {

        }

        public string InsertarProfesor(string Profesor_cedula, string Profesor_nombre, string Profesor_primerApellido,
            string Profesor_segundoApellido, string Profesor_telefono, string Profesor_correoElectronico,
            string Profesor_direccion, string Profesor_estado)
        {
            Profesor nuevoProfesor = new Profesor(Profesor_cedula, Profesor_nombre, Profesor_primerApellido,
                                                    Profesor_segundoApellido, Profesor_telefono, Profesor_correoElectronico,
                                                    Profesor_direccion, Profesor_estado);

            using (ServicioProfesor elProfesor = new ServicioProfesor()) { 
            return elProfesor.InsertarProfesor(nuevoProfesor);
        }
    }

        public object ListarProfesor()
        {
            using (ServicioProfesor elProfesor = new ServicioProfesor())
                return elProfesor.ListarProfesor();
        }

        public string ModificarProfesor(int Profesor_id, string Profesor_cedula, string Profesor_nombre, string Profesor_primerApellido,
            string Profesor_segundoApellido, string Profesor_telefono, string Profesor_correoElectronico,
            string Profesor_direccion, string Profesor_estado)
        {
            Profesor modificarProfesor = new Profesor(Profesor_id, Profesor_cedula, Profesor_nombre, Profesor_primerApellido,
                                                   Profesor_segundoApellido, Profesor_telefono, Profesor_correoElectronico,
                                                   Profesor_direccion, Profesor_estado);

            using (ServicioProfesor elProfesor = new ServicioProfesor())
            return elProfesor.ModificarProfesor(modificarProfesor);
        
        }

        public DataSet ConsultarProfesor(int Profesor_id)
        {
            //Profesor ConsultarProfesor = new Profesor(Profesor_id);
            using (ServicioProfesor elProfesor = new ServicioProfesor())
            {
                return elProfesor.ConsultarProfesor(Profesor_id);
            }
        }
    }
}
