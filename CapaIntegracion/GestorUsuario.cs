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
    public class GestorUsuario : servicio, IDisposable
    {
        public GestorUsuario()
        {

        }

        public void Dispose()
        {

        }

        public string InsertarUsuario(string Usuario_nombre, string Usuario_contraseña, string Usuario_estado)
        {
            Usuario nuevoUsuario = new Usuario(Usuario_nombre, Usuario_contraseña, Usuario_estado);

            using (ServicioUsuario elUsuario = new ServicioUsuario())
            {
                return elUsuario.InsertarUsuario(nuevoUsuario);
            }
        }

        public DataTable ListarUsuario()
        {
            using (ServicioUsuario elUsuario = new ServicioUsuario())
                return elUsuario.ListarUsuario();
        }

        public string ModificarUsuario(int TUsuario_id, string Usuario_nombre, string Usuario_contraseña, string Usuario_estado)
        {
            Usuario modificarUsuario = new Usuario(TUsuario_id, Usuario_nombre, Usuario_contraseña, Usuario_estado);

            using (ServicioUsuario elUsuario = new ServicioUsuario())
                return elUsuario.ModificarUsuario(modificarUsuario);

        }

        public DataSet ConsultarUsuario(int TUsuario_id)
        {
            using (ServicioUsuario elUsuario = new ServicioUsuario())
            {
                return elUsuario.ConsultarUsuario(TUsuario_id);
            }
        }
    }
}

