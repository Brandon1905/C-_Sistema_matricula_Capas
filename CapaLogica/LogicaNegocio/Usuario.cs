using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Usuario
    {
        #region ATRIBUTOS
        protected int tUsuario_id;
        protected string usuario_nombre;
        protected string usuario_contraseña;
        protected string usuario_estado;
        #endregion

        #region CONSTRUCRORES
        public Usuario()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pusuario_nombre"></param>
        /// <param name="Pusuario_contraseña"></param>
        /// <param name="Pusuario_estado"></param>
        public Usuario(string Pusuario_nombre, string Pusuario_contraseña, string Pusuario_estado)
        {
            TUsuario_id = 0;
            Usuario_nombre = Pusuario_nombre;
            Usuario_contraseña = Pusuario_contraseña;
            Usuario_estado = Pusuario_estado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PtUsuario_id"></param>
        /// <param name="Pusuario_nombre"></param>
        /// <param name="Pusuario_contraseña"></param>
        /// <param name="Pusuario_estado"></param>
        public Usuario(int PtUsuario_id, string Pusuario_nombre, string Pusuario_contraseña, string Pusuario_estado)
        {
            TUsuario_id = PtUsuario_id;
            Usuario_nombre = Pusuario_nombre;
            Usuario_contraseña = Pusuario_contraseña;
            Usuario_estado = Pusuario_estado;
        }
        #endregion

        #region GETS_SETS
        public int TUsuario_id { get => tUsuario_id; set => tUsuario_id = value; }
        public string Usuario_nombre { get => usuario_nombre; set => usuario_nombre = value; }
        public string Usuario_contraseña { get => usuario_contraseña; set => usuario_contraseña = value; }
        public string Usuario_estado { get => usuario_estado; set => usuario_estado = value; }
        #endregion
    }
}
