using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica.Servicios;
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio;

namespace CapaIntegracion
{
    public class GestorGrupo : servicio, IDisposable
    {
        public GestorGrupo()
        {

        }

        public void Dispose()
        {

        }

        public string InsertarGrupo(string Grupo_descripcion, string Grupo_estado)
        {
            Grupo nuevoGrupo = new Grupo(Grupo_descripcion, Grupo_estado);

            using (ServicioGrupo elGrupo = new ServicioGrupo())
                return elGrupo.InsertarGrupo(nuevoGrupo);
        }

        public object ListarGrupo()
        {
            using (ServicioGrupo elGrupo = new ServicioGrupo())
                return elGrupo.ListarGrupo();
        }

        public string ModificarGrupo(int Grupo_id, string Grupo_descripcion, string Grupo_estado)
        {
            Grupo modificarGrupo = new Grupo(Grupo_id, Grupo_descripcion, Grupo_estado);

            using (ServicioGrupo elGrupo = new ServicioGrupo())
                return elGrupo.ModificarGrupo(modificarGrupo);
        }

        public DataSet ConsultarGrupo(int Grupo_id)
        {
            using (ServicioGrupo elGrupo = new ServicioGrupo())
            {
                return elGrupo.ConsultarGrupo(Grupo_id);
            }
        }
    }
}
